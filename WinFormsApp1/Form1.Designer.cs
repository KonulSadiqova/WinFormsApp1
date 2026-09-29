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
            txtNumberOne = new TextBox();
            txtNumberTwo = new TextBox();
            cmbCommand = new ComboBox();
            lblAnswer = new Label();
            btnResult = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtNumberOne
            // 
            txtNumberOne.Location = new Point(64, 43);
            txtNumberOne.Name = "txtNumberOne";
            txtNumberOne.Size = new Size(341, 27);
            txtNumberOne.TabIndex = 0;
            txtNumberOne.Text = "0";
            // 
            // txtNumberTwo
            // 
            txtNumberTwo.Location = new Point(64, 119);
            txtNumberTwo.Name = "txtNumberTwo";
            txtNumberTwo.Size = new Size(341, 27);
            txtNumberTwo.TabIndex = 1;
            txtNumberTwo.Text = "0";
            // 
            // cmbCommand
            // 
            cmbCommand.FormattingEnabled = true;
            cmbCommand.Location = new Point(64, 189);
            cmbCommand.Name = "cmbCommand";
            cmbCommand.Size = new Size(341, 28);
            cmbCommand.TabIndex = 2;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(69, 247);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(72, 20);
            lblAnswer.TabIndex = 3;
            lblAnswer.Text = "Answer: 0";
            // 
            // btnResult
            // 
            btnResult.Location = new Point(64, 270);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(335, 50);
            btnResult.TabIndex = 4;
            btnResult.Text = "Result";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(64, 340);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(335, 46);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnResult);
            Controls.Add(lblAnswer);
            Controls.Add(cmbCommand);
            Controls.Add(txtNumberTwo);
            Controls.Add(txtNumberOne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumberOne;
        private TextBox txtNumberTwo;
        private ComboBox cmbCommand;
        private Label lblAnswer;
        private Button btnResult;
        private Button btnClear;
    }
}
