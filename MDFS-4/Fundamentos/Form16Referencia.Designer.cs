
namespace Fundamentos
{
    partial class Form16Referencia
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.btnllamada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(25, 32);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(192, 29);
            this.txtnumero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(21, 78);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(104, 24);
            this.lblres.TabIndex = 2;
            this.lblres.Text = "Resultado: ";
            // 
            // btnllamada
            // 
            this.btnllamada.Location = new System.Drawing.Point(25, 124);
            this.btnllamada.Name = "btnllamada";
            this.btnllamada.Size = new System.Drawing.Size(137, 57);
            this.btnllamada.TabIndex = 3;
            this.btnllamada.Text = "LLamada";
            this.btnllamada.UseVisualStyleBackColor = true;
            this.btnllamada.Click += new System.EventHandler(this.btnllamada_Click);
            // 
            // Form16Referencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 210);
            this.Controls.Add(this.btnllamada);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form16Referencia";
            this.Text = "Form16Referencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button btnllamada;
    }
}