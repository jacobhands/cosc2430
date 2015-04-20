namespace Chapter12Problem8
{
    partial class CalculatorForm
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radSubtract = new System.Windows.Forms.RadioButton();
            this.radMultiply = new System.Windows.Forms.RadioButton();
            this.radDevide = new System.Windows.Forms.RadioButton();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(96, 95);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result:";
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(13, 101);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(44, 17);
            this.radAdd.TabIndex = 4;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // radSubtract
            // 
            this.radSubtract.AutoSize = true;
            this.radSubtract.Location = new System.Drawing.Point(13, 125);
            this.radSubtract.Name = "radSubtract";
            this.radSubtract.Size = new System.Drawing.Size(65, 17);
            this.radSubtract.TabIndex = 5;
            this.radSubtract.TabStop = true;
            this.radSubtract.Text = "Subtract";
            this.radSubtract.UseVisualStyleBackColor = true;
            // 
            // radMultiply
            // 
            this.radMultiply.AutoSize = true;
            this.radMultiply.Location = new System.Drawing.Point(13, 149);
            this.radMultiply.Name = "radMultiply";
            this.radMultiply.Size = new System.Drawing.Size(60, 17);
            this.radMultiply.TabIndex = 6;
            this.radMultiply.TabStop = true;
            this.radMultiply.Text = "Multiply";
            this.radMultiply.UseVisualStyleBackColor = true;
            // 
            // radDevide
            // 
            this.radDevide.AutoSize = true;
            this.radDevide.Location = new System.Drawing.Point(13, 173);
            this.radDevide.Name = "radDevide";
            this.radDevide.Size = new System.Drawing.Size(59, 17);
            this.radDevide.TabIndex = 7;
            this.radDevide.TabStop = true;
            this.radDevide.Text = "Devide";
            this.radDevide.UseVisualStyleBackColor = true;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(71, 10);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 8;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(71, 36);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(74, 62);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 11;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 198);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.radDevide);
            this.Controls.Add(this.radMultiply);
            this.Controls.Add(this.radSubtract);
            this.Controls.Add(this.radAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radSubtract;
        private System.Windows.Forms.RadioButton radMultiply;
        private System.Windows.Forms.RadioButton radDevide;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblResult;
    }
}

