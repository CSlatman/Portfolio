namespace WinFormsApp1___Training___List___Ticketmeester
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
            label1 = new Label();
            HelloWorldTB = new TextBox();
            HellowWorldBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 83);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Hello World  Label";
            // 
            // HelloWorldTB
            // 
            HelloWorldTB.Location = new Point(300, 80);
            HelloWorldTB.Name = "HelloWorldTB";
            HelloWorldTB.Size = new Size(100, 23);
            HelloWorldTB.TabIndex = 1;
            // 
            // HellowWorldBtn
            // 
            HellowWorldBtn.Location = new Point(280, 233);
            HellowWorldBtn.Name = "HellowWorldBtn";
            HellowWorldBtn.Size = new Size(147, 95);
            HellowWorldBtn.TabIndex = 2;
            HellowWorldBtn.Text = "Hello World Button";
            HellowWorldBtn.UseVisualStyleBackColor = true;
            HellowWorldBtn.Click += HellowWorldBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HellowWorldBtn);
            Controls.Add(HelloWorldTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox HelloWorldTB;
        private Button HellowWorldBtn;
    }
}