namespace BetterWinProject
{
    partial class MainForm
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
            textBox1 = new TextBox();
            sayHelloBtn = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(174, 172);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(192, 48);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(391, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(429, 55);
            textBox1.TabIndex = 1;
            // 
            // sayHelloBtn
            // 
            sayHelloBtn.Location = new Point(311, 349);
            sayHelloBtn.Name = "sayHelloBtn";
            sayHelloBtn.Size = new Size(314, 135);
            sayHelloBtn.TabIndex = 2;
            sayHelloBtn.Text = "Say Hello!";
            sayHelloBtn.UseVisualStyleBackColor = true;
            sayHelloBtn.Click += sayHelloBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 644);
            Controls.Add(sayHelloBtn);
            Controls.Add(textBox1);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "MainForm";
            Text = "MainForm by denkataden32";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox textBox1;
        private Button sayHelloBtn;
    }
}