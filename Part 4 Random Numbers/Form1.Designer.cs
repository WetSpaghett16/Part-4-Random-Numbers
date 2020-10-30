namespace Random_Numbers
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
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.lblMessage3 = new System.Windows.Forms.Label();
            this.txtMaximum = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnInteger = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.Location = new System.Drawing.Point(13, 13);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(219, 30);
            this.lblMessage1.TabIndex = 0;
            this.lblMessage1.Text = "ENTER A VALUE:";
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage2.Location = new System.Drawing.Point(12, 66);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(70, 25);
            this.lblMessage2.TabIndex = 1;
            this.lblMessage2.Text = "Minimum";
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(96, 69);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(100, 20);
            this.txtMinimum.TabIndex = 2;
            // 
            // lblMessage3
            // 
            this.lblMessage3.AutoSize = true;
            this.lblMessage3.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage3.Location = new System.Drawing.Point(14, 106);
            this.lblMessage3.Name = "lblMessage3";
            this.lblMessage3.Size = new System.Drawing.Size(74, 25);
            this.lblMessage3.TabIndex = 3;
            this.lblMessage3.Text = "Maximum";
            // 
            // txtMaximum
            // 
            this.txtMaximum.Location = new System.Drawing.Point(96, 110);
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.Size = new System.Drawing.Size(100, 20);
            this.txtMaximum.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(82, 192);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // btnInteger
            // 
            this.btnInteger.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteger.Location = new System.Drawing.Point(12, 152);
            this.btnInteger.Name = "btnInteger";
            this.btnInteger.Size = new System.Drawing.Size(89, 23);
            this.btnInteger.TabIndex = 6;
            this.btnInteger.Text = "Get Integer";
            this.btnInteger.UseVisualStyleBackColor = true;
            this.btnInteger.Click += new System.EventHandler(this.btnInteger_Click_1);
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(171, 152);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(89, 23);
            this.btnDouble.TabIndex = 7;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(275, 276);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInteger);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtMaximum);
            this.Controls.Add(this.lblMessage3);
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblMessage1);
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.Label lblMessage3;
        private System.Windows.Forms.TextBox txtMaximum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnInteger;
        private System.Windows.Forms.Button btnDouble;
    }
}

