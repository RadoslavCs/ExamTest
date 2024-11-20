namespace ExamTest
{
    partial class homeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabTest = new TabPage();
            txtResult = new RichTextBox();
            lblChooseTest = new Label();
            cmboxTests = new ComboBox();
            btnGetAnswer = new Button();
            btnGetQuestion = new Button();
            tabEdit = new TabPage();
            btnClean = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAnswer = new TextBox();
            txtQuestion = new TextBox();
            txtTestName = new TextBox();
            tabControl.SuspendLayout();
            tabTest.SuspendLayout();
            tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabTest);
            tabControl.Controls.Add(tabEdit);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1603, 926);
            tabControl.TabIndex = 0;
            // 
            // tabTest
            // 
            tabTest.Controls.Add(txtResult);
            tabTest.Controls.Add(lblChooseTest);
            tabTest.Controls.Add(cmboxTests);
            tabTest.Controls.Add(btnGetAnswer);
            tabTest.Controls.Add(btnGetQuestion);
            tabTest.Location = new Point(4, 34);
            tabTest.Margin = new Padding(4, 5, 4, 5);
            tabTest.Name = "tabTest";
            tabTest.Padding = new Padding(4, 5, 4, 5);
            tabTest.Size = new Size(1595, 624);
            tabTest.TabIndex = 0;
            tabTest.Text = "Test";
            tabTest.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtResult.Location = new Point(11, 10);
            txtResult.Margin = new Padding(4, 5, 4, 5);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(1383, 592);
            txtResult.TabIndex = 8;
            txtResult.Text = "This is a test text";
            // 
            // lblChooseTest
            // 
            lblChooseTest.AutoSize = true;
            lblChooseTest.Location = new Point(1404, 113);
            lblChooseTest.Margin = new Padding(4, 0, 4, 0);
            lblChooseTest.Name = "lblChooseTest";
            lblChooseTest.Size = new Size(107, 25);
            lblChooseTest.TabIndex = 7;
            lblChooseTest.Text = "Choose Test";
            // 
            // cmboxTests
            // 
            cmboxTests.FormattingEnabled = true;
            cmboxTests.Location = new Point(1407, 143);
            cmboxTests.Margin = new Padding(4, 5, 4, 5);
            cmboxTests.Name = "cmboxTests";
            cmboxTests.Size = new Size(171, 33);
            cmboxTests.TabIndex = 6;
            // 
            // btnGetAnswer
            // 
            btnGetAnswer.Location = new Point(1407, 58);
            btnGetAnswer.Margin = new Padding(4, 5, 4, 5);
            btnGetAnswer.Name = "btnGetAnswer";
            btnGetAnswer.Size = new Size(173, 38);
            btnGetAnswer.TabIndex = 4;
            btnGetAnswer.Text = "Get Answer";
            btnGetAnswer.UseVisualStyleBackColor = true;
            btnGetAnswer.Click += btnGetAnswer_Click;
            // 
            // btnGetQuestion
            // 
            btnGetQuestion.Location = new Point(1407, 10);
            btnGetQuestion.Margin = new Padding(4, 5, 4, 5);
            btnGetQuestion.Name = "btnGetQuestion";
            btnGetQuestion.Size = new Size(173, 38);
            btnGetQuestion.TabIndex = 3;
            btnGetQuestion.Text = "Get Question";
            btnGetQuestion.UseVisualStyleBackColor = true;
            btnGetQuestion.Click += btnGetQuestion_Click;
            // 
            // tabEdit
            // 
            tabEdit.Controls.Add(btnClean);
            tabEdit.Controls.Add(btnAdd);
            tabEdit.Controls.Add(dataGridView1);
            tabEdit.Controls.Add(label3);
            tabEdit.Controls.Add(label2);
            tabEdit.Controls.Add(label1);
            tabEdit.Controls.Add(txtAnswer);
            tabEdit.Controls.Add(txtQuestion);
            tabEdit.Controls.Add(txtTestName);
            tabEdit.Location = new Point(4, 34);
            tabEdit.Margin = new Padding(4, 5, 4, 5);
            tabEdit.Name = "tabEdit";
            tabEdit.Padding = new Padding(4, 5, 4, 5);
            tabEdit.Size = new Size(1595, 888);
            tabEdit.TabIndex = 1;
            tabEdit.Text = "Edit";
            tabEdit.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(1470, 532);
            btnClean.Margin = new Padding(4, 5, 4, 5);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(107, 38);
            btnClean.TabIndex = 8;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1470, 483);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(4, 380);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1587, 503);
            dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 202);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 5;
            label3.Text = "Answer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 4;
            label2.Text = "Question";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 3;
            label1.Text = "Test Name";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(9, 233);
            txtAnswer.Margin = new Padding(4, 5, 4, 5);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(1567, 237);
            txtAnswer.TabIndex = 2;
            // 
            // txtQuestion
            // 
            txtQuestion.Location = new Point(11, 115);
            txtQuestion.Margin = new Padding(4, 5, 4, 5);
            txtQuestion.Multiline = true;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Size = new Size(1578, 71);
            txtQuestion.TabIndex = 1;
            // 
            // txtTestName
            // 
            txtTestName.Location = new Point(11, 38);
            txtTestName.Margin = new Padding(4, 5, 4, 5);
            txtTestName.Name = "txtTestName";
            txtTestName.Size = new Size(375, 31);
            txtTestName.TabIndex = 0;
            // 
            // homeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1603, 926);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "homeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam Tests";
            Load += homeForm_Load;
            tabControl.ResumeLayout(false);
            tabTest.ResumeLayout(false);
            tabTest.PerformLayout();
            tabEdit.ResumeLayout(false);
            tabEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabTest;
        private Button btnGetAnswer;
        private Button btnGetQuestion;
        private TabPage tabEdit;
        private TextBox txtAnswer;
        private TextBox txtQuestion;
        private TextBox txtTestName;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnClean;
        private ComboBox cmboxTests;
        private Label lblChooseTest;
        private RichTextBox txtResult;
    }
}
