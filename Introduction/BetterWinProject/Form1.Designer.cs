namespace BetterWinProject
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
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            sayHelloBtn = new Button();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(285, 136);
            firstNameLabel.Margin = new Padding(7, 0, 7, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(160, 41);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(517, 133);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(375, 47);
            firstNameTextBox.TabIndex = 1;
            // 
            // sayHelloBtn
            // 
            sayHelloBtn.Location = new Point(348, 479);
            sayHelloBtn.Name = "sayHelloBtn";
            sayHelloBtn.Size = new Size(374, 96);
            sayHelloBtn.TabIndex = 3;
            sayHelloBtn.Text = "Say Hello!";
            sayHelloBtn.UseVisualStyleBackColor = true;
            sayHelloBtn.Click += sayHelloBtn_Click;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(517, 225);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(375, 47);
            lastNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(285, 228);
            lastNameLabel.Margin = new Padding(7, 0, 7, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(157, 41);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 685);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(sayHelloBtn);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 7, 7, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Button sayHelloBtn;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
    }
}