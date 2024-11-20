//Aplikaciu som urobil podla:
//https://chatgpt.com/share/673cc80b-0c8c-800d-8af6-44d9138c53e2
using ExamTest.Models;
using System.Windows.Forms;

namespace ExamTest
{
    public partial class homeForm : Form
    {
        private string _question = string.Empty;
        private string _answer = string.Empty;

        public homeForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            txtResult.Clear();
            using (var context = new AppDbContext())
            {
                // Na��taj v�etky �daje z tabu�ky Tests
                var data = context.Tests.ToList();

                // Nastav DataGridView zdroj �dajov
                dataGridView1.DataSource = data;

                // Na��tanie v�etk�ch n�zvov testov
                var testNames = context.Tests
                    .Select(t => t.TestName)
                    .Distinct() // Odstr�ni duplicitn� hodnoty
                    .ToList();

                // Vy�istenie ComboBox pred pridan�m nov�ch polo�iek
                cmboxTests.Items.Clear();

                // Pridanie n�zvov do ComboBox
                cmboxTests.Items.AddRange(testNames.ToArray());
              
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var test = new Test
                {
                    SysDate = DateTime.Now,
                    TestName = txtTestName.Text,
                    Question = txtQuestion.Text,
                    Answer = txtAnswer.Text,
                };
                if (!String.IsNullOrWhiteSpace(test.TestName)
                    || !String.IsNullOrWhiteSpace(test.Question)
                    || !String.IsNullOrWhiteSpace(test.Answer))
                {
                    context.Tests.Add(test);
                    context.SaveChanges();
                }
            }
            LoadData();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtAnswer.Clear();
            txtQuestion.Clear();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadRandomQuestion()
        {
            using (var context = new AppDbContext())
            {
                // Na��taj n�hodn� ot�zku
                if (!string.IsNullOrWhiteSpace(cmboxTests.Text))
                {
                    var randomQuestion = context.Tests
                   .OrderBy(q => Guid.NewGuid()) // Generuje n�hodn� poradie
                   .Select(q => new { q.TestName, q.Question, q.Answer }) // Na��taj iba ot�zku a odpove� a TestName
                   .Where(q => q.TestName == cmboxTests.Text)
                   .FirstOrDefault(); // Vezmi prv� z�znam


                    if (randomQuestion != null)
                    {
                        // Zobrazi� ot�zku a odpove� na formul�ri (napr�klad v TextBoxoch)
                        _question = randomQuestion.Question;
                        _answer = randomQuestion.Answer;
                    }
                    else
                    {
                        MessageBox.Show("V datab�ze nie s� �iadne ot�zky!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mus�te si vybra� Test!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
        }

        private void btnGetQuestion_Click(object sender, EventArgs e)
        {
            LoadRandomQuestion();
            txtResult.Clear();
            txtResult.Text = _question;
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text = _answer;

        }
    }


}
