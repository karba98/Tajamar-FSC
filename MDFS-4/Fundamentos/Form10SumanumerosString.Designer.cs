
namespace Fundamentos
{
    partial class Form10SumanumerosString
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
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsumar = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(166, 36);
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(283, 29);
            this.txtnumeros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numeros";
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(74, 89);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(375, 36);
            this.btnsumar.TabIndex = 2;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.ForeColor = System.Drawing.Color.Red;
            this.lblres.Location = new System.Drawing.Point(162, 173);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(69, 24);
            this.lblres.TabIndex = 3;
            this.lblres.Text = "Suma: ";
            // 
            // Form10SumanumerosString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 318);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumeros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form10SumanumerosString";
            this.Text = "Form10SumanumerosString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Label lblres;
    }
}