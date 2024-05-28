namespace WinFormsApp1
{
    partial class Form1
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
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            buttonAutofill = new Button();
            button1 = new Button();
            comboBoxDifficulty = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(912, 16);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 423);
            textBox1.TabIndex = 0;
            textBox1.Text = "049000030\r\n050610000\r\n008029506\r\n800907004\r\n700000081\r\n025041300\r\n200076010\r\n500408700\r\n087000095";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(900, 900);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonAutofill
            // 
            buttonAutofill.Location = new Point(915, 450);
            buttonAutofill.Name = "buttonAutofill";
            buttonAutofill.Size = new Size(112, 34);
            buttonAutofill.TabIndex = 2;
            buttonAutofill.Text = "Autofill";
            buttonAutofill.UseVisualStyleBackColor = true;
            buttonAutofill.Click += buttonAutofill_Click;
            // 
            // button1
            // 
            button1.Location = new Point(912, 490);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Step";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxDifficulty
            // 
            comboBoxDifficulty.FormattingEnabled = true;
            comboBoxDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            comboBoxDifficulty.Location = new Point(914, 598);
            comboBoxDifficulty.Name = "comboBoxDifficulty";
            comboBoxDifficulty.Size = new Size(182, 33);
            comboBoxDifficulty.TabIndex = 4;
            comboBoxDifficulty.SelectedIndexChanged += comboBoxDifficulty_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(916, 567);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 5;
            label1.Text = "Difficulty";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 923);
            Controls.Add(label1);
            Controls.Add(comboBoxDifficulty);
            Controls.Add(button1);
            Controls.Add(buttonAutofill);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Sudoku Solver";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button buttonAutofill;
        private Button button1;
        private ComboBox comboBoxDifficulty;
        private Label label1;
    }
}
