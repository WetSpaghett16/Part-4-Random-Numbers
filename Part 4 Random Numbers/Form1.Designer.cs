namespace Part_4_Random_Numbers
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMessage3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(82, 192);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(76, 148);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(272, 285);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblMessage3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.lblMessage1);
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMessage3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSubmit;
    }
}

