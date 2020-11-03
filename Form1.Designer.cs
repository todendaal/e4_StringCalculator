namespace e4_StringCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCalcInput = new System.Windows.Forms.RichTextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblheading1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "e4 String Calculator";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCalcInput);
            this.panel1.Location = new System.Drawing.Point(17, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 378);
            this.panel1.TabIndex = 1;
            // 
            // txtCalcInput
            // 
            this.txtCalcInput.Location = new System.Drawing.Point(3, 0);
            this.txtCalcInput.Name = "txtCalcInput";
            this.txtCalcInput.Size = new System.Drawing.Size(374, 375);
            this.txtCalcInput.TabIndex = 0;
            this.txtCalcInput.Text = "";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(395, 221);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(164, 69);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate >>";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFinal);
            this.panel2.Controls.Add(this.txtResults);
            this.panel2.Location = new System.Drawing.Point(557, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 378);
            this.panel2.TabIndex = 3;
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(0, 0);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(425, 310);
            this.txtResults.TabIndex = 0;
            this.txtResults.Text = "";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.ForeColor = System.Drawing.Color.Red;
            this.lblFinal.Location = new System.Drawing.Point(13, 313);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(0, 29);
            this.lblFinal.TabIndex = 1;
            // 
            // lblheading1
            // 
            this.lblheading1.AutoSize = true;
            this.lblheading1.Location = new System.Drawing.Point(314, 67);
            this.lblheading1.Name = "lblheading1";
            this.lblheading1.Size = new System.Drawing.Size(80, 17);
            this.lblheading1.TabIndex = 4;
            this.lblheading1.Text = "String input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Process output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblheading1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtCalcInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtResults;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblheading1;
        private System.Windows.Forms.Label label2;
    }
}

