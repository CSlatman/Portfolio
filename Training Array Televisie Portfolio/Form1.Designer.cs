namespace Training_Array_Televisie_Portfolio
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeChannel = new System.Windows.Forms.Button();
            this.radBtnOn = new System.Windows.Forms.RadioButton();
            this.radBtnOff = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(539, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "On or Off?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Which channel is on?";
            // 
            // btnChangeChannel
            // 
            this.btnChangeChannel.Location = new System.Drawing.Point(459, 262);
            this.btnChangeChannel.Name = "btnChangeChannel";
            this.btnChangeChannel.Size = new System.Drawing.Size(154, 23);
            this.btnChangeChannel.TabIndex = 4;
            this.btnChangeChannel.Text = "Change Channel";
            this.btnChangeChannel.UseVisualStyleBackColor = true;
            this.btnChangeChannel.Click += new System.EventHandler(this.btnChangeChannel_Click);
            // 
            // radBtnOn
            // 
            this.radBtnOn.AutoSize = true;
            this.radBtnOn.Location = new System.Drawing.Point(138, 244);
            this.radBtnOn.Name = "radBtnOn";
            this.radBtnOn.Size = new System.Drawing.Size(41, 19);
            this.radBtnOn.TabIndex = 5;
            this.radBtnOn.TabStop = true;
            this.radBtnOn.Text = "On";
            this.radBtnOn.UseVisualStyleBackColor = true;
            this.radBtnOn.CheckedChanged += new System.EventHandler(this.radBtnOn_CheckedChanged);
            // 
            // radBtnOff
            // 
            this.radBtnOff.AutoSize = true;
            this.radBtnOff.Location = new System.Drawing.Point(138, 266);
            this.radBtnOff.Name = "radBtnOff";
            this.radBtnOff.Size = new System.Drawing.Size(42, 19);
            this.radBtnOff.TabIndex = 6;
            this.radBtnOff.TabStop = true;
            this.radBtnOff.Text = "Off";
            this.radBtnOff.UseVisualStyleBackColor = true;
            this.radBtnOff.CheckedChanged += new System.EventHandler(this.radBtnOff_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(660, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radBtnOff);
            this.Controls.Add(this.radBtnOn);
            this.Controls.Add(this.btnChangeChannel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button btnChangeChannel;
        private RadioButton radBtnOn;
        private RadioButton radBtnOff;
        private ListBox listBox1;
    }
}