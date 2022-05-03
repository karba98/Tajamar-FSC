
namespace Fundamentos
{
    partial class Form08Char
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
            this.txtletras = new System.Windows.Forms.TextBox();
            this.txtsimbolos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpuntuacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrecorrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letras";
            // 
            // txtletras
            // 
            this.txtletras.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtletras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtletras.ForeColor = System.Drawing.SystemColors.Window;
            this.txtletras.Location = new System.Drawing.Point(32, 63);
            this.txtletras.Multiline = true;
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(261, 180);
            this.txtletras.TabIndex = 1;
            // 
            // txtsimbolos
            // 
            this.txtsimbolos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtsimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsimbolos.Location = new System.Drawing.Point(347, 63);
            this.txtsimbolos.Multiline = true;
            this.txtsimbolos.Name = "txtsimbolos";
            this.txtsimbolos.Size = new System.Drawing.Size(261, 180);
            this.txtsimbolos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Símbolos";
            // 
            // txtnumeros
            // 
            this.txtnumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtnumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeros.Location = new System.Drawing.Point(32, 275);
            this.txtnumeros.Multiline = true;
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(261, 171);
            this.txtnumeros.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numeros";
            // 
            // txtpuntuacion
            // 
            this.txtpuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpuntuacion.Location = new System.Drawing.Point(349, 275);
            this.txtpuntuacion.Multiline = true;
            this.txtpuntuacion.Name = "txtpuntuacion";
            this.txtpuntuacion.Size = new System.Drawing.Size(261, 171);
            this.txtpuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puntuación";
            // 
            // btnrecorrer
            // 
            this.btnrecorrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecorrer.Location = new System.Drawing.Point(32, 464);
            this.btnrecorrer.Name = "btnrecorrer";
            this.btnrecorrer.Size = new System.Drawing.Size(576, 60);
            this.btnrecorrer.TabIndex = 8;
            this.btnrecorrer.Text = "Recorrer ASCII";
            this.btnrecorrer.UseVisualStyleBackColor = true;
            this.btnrecorrer.Click += new System.EventHandler(this.btnrecorrer_Click);
            // 
            // Form08Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 536);
            this.Controls.Add(this.btnrecorrer);
            this.Controls.Add(this.txtpuntuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsimbolos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.label1);
            this.Name = "Form08Char";
            this.Text = "Form08cHAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtletras;
        private System.Windows.Forms.TextBox txtsimbolos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpuntuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrecorrer;
    }
}