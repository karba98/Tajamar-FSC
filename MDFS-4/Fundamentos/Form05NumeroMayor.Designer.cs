
namespace Fundamentos
{
    partial class Form05NumeroMayor
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.btneval = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(34, 49);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 0;
            this.txtn1.Text = "Numero 1 ";
            this.txtn1.TextChanged += new System.EventHandler(this.txtn1_TextChanged);
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(34, 97);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 1;
            this.txtn2.Text = "Numero 2";
            this.txtn2.TextChanged += new System.EventHandler(this.txtn2_TextChanged);
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(34, 153);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(100, 20);
            this.txtn3.TabIndex = 2;
            this.txtn3.Text = "Numero 3";
            this.txtn3.TextChanged += new System.EventHandler(this.txtn3_TextChanged);
            // 
            // btneval
            // 
            this.btneval.Location = new System.Drawing.Point(34, 210);
            this.btneval.Name = "btneval";
            this.btneval.Size = new System.Drawing.Size(100, 35);
            this.btneval.TabIndex = 3;
            this.btneval.Text = "Evaluar";
            this.btneval.UseVisualStyleBackColor = true;
            this.btneval.Click += new System.EventHandler(this.btneval_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.Location = new System.Drawing.Point(34, 295);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(91, 22);
            this.lblres.TabIndex = 4;
            this.lblres.Text = "Resultado";
            // 
            // Form05NumeroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 450);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.btneval);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Name = "Form05NumeroMayor";
            this.Text = "Form05NumeroMayor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.Button btneval;
        private System.Windows.Forms.Label lblres;
    }
}