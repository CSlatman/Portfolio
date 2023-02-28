namespace Prijzen_met_BTW_berekenen_WFA_Portfolio
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
            this.txtBoxPriiceInput = new System.Windows.Forms.TextBox();
            this.radBtnLowVAT = new System.Windows.Forms.RadioButton();
            this.radBtnHighVAT = new System.Windows.Forms.RadioButton();
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxPriiceInput
            // 
            this.txtBoxPriiceInput.Location = new System.Drawing.Point(170, 140);
            this.txtBoxPriiceInput.Name = "txtBoxPriiceInput";
            this.txtBoxPriiceInput.Size = new System.Drawing.Size(222, 23);
            this.txtBoxPriiceInput.TabIndex = 0;
            this.txtBoxPriiceInput.TextChanged += new System.EventHandler(this.txtBoxPriiceInput_TextChanged);
            // 
            // radBtnLowVAT
            // 
            this.radBtnLowVAT.AutoSize = true;
            this.radBtnLowVAT.Location = new System.Drawing.Point(170, 169);
            this.radBtnLowVAT.Name = "radBtnLowVAT";
            this.radBtnLowVAT.Size = new System.Drawing.Size(41, 19);
            this.radBtnLowVAT.TabIndex = 1;
            this.radBtnLowVAT.TabStop = true;
            this.radBtnLowVAT.Text = "6%";
            this.radBtnLowVAT.UseVisualStyleBackColor = true;
            this.radBtnLowVAT.CheckedChanged += new System.EventHandler(this.radBtnLowVAT_CheckedChanged);
            // 
            // radBtnHighVAT
            // 
            this.radBtnHighVAT.AutoSize = true;
            this.radBtnHighVAT.Location = new System.Drawing.Point(345, 169);
            this.radBtnHighVAT.Name = "radBtnHighVAT";
            this.radBtnHighVAT.Size = new System.Drawing.Size(47, 19);
            this.radBtnHighVAT.TabIndex = 2;
            this.radBtnHighVAT.TabStop = true;
            this.radBtnHighVAT.Text = "21%";
            this.radBtnHighVAT.UseVisualStyleBackColor = true;
            this.radBtnHighVAT.CheckedChanged += new System.EventHandler(this.radBtnHighVAT_CheckedChanged);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(435, 140);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(113, 23);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Calculate >";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Location = new System.Drawing.Point(582, 140);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(164, 23);
            this.txtBoxOutput.TabIndex = 4;
            this.txtBoxOutput.TextChanged += new System.EventHandler(this.txtBoxOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxOutput);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.radBtnHighVAT);
            this.Controls.Add(this.radBtnLowVAT);
            this.Controls.Add(this.txtBoxPriiceInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxPriiceInput;
        private RadioButton radBtnLowVAT;
        private RadioButton radBtnHighVAT;
        private Button btnConverter;
        private TextBox txtBoxOutput;
        private Label label1;
        private Label label2;
    }
}