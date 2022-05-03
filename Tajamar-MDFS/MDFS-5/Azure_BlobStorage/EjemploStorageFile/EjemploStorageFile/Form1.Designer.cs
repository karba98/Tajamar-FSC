
namespace EjemploStorageFile
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
            this.botonleerfichero = new System.Windows.Forms.Button();
            this.txtcontenido = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // botonleerfichero
            // 
            this.botonleerfichero.Location = new System.Drawing.Point(12, 26);
            this.botonleerfichero.Name = "botonleerfichero";
            this.botonleerfichero.Size = new System.Drawing.Size(113, 40);
            this.botonleerfichero.TabIndex = 0;
            this.botonleerfichero.Text = "LEER";
            this.botonleerfichero.UseVisualStyleBackColor = true;
            this.botonleerfichero.Click += new System.EventHandler(this.botonleerfichero_Click);
            // 
            // txtcontenido
            // 
            this.txtcontenido.Location = new System.Drawing.Point(12, 83);
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.Size = new System.Drawing.Size(1319, 846);
            this.txtcontenido.TabIndex = 1;
            this.txtcontenido.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 941);
            this.Controls.Add(this.txtcontenido);
            this.Controls.Add(this.botonleerfichero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonleerfichero;
        private System.Windows.Forms.RichTextBox txtcontenido;
    }
}

