
namespace Fundamentos
{
    partial class Form09validarEmail
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
            this.lblmail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(37, 54);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(71, 25);
            this.lblmail.TabIndex = 0;
            this.lblmail.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(113, 54);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(344, 31);
            this.txtemail.TabIndex = 1;
            // 
            // btnvalidar
            // 
            this.btnvalidar.Location = new System.Drawing.Point(202, 136);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(176, 43);
            this.btnvalidar.TabIndex = 2;
            this.btnvalidar.Text = "Validar";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(257, 237);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(0, 25);
            this.lblres.TabIndex = 3;
            // 
            // Form09validarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 315);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form09validarEmail";
            this.Text = "Form09validarEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.Label lblres;
    }
}