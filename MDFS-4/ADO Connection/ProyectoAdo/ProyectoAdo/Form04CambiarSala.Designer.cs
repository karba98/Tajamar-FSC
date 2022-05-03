
namespace ProyectoAdo
{
    partial class Form04CambiarSala
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
            this.btncambiar = new System.Windows.Forms.Button();
            this.lstsalas = new System.Windows.Forms.ListBox();
            this.txtnewsala = new System.Windows.Forms.TextBox();
            this.txtch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(-1, -2);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(308, 56);
            this.btncambiar.TabIndex = 0;
            this.btncambiar.Text = "Cambiar";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // lstsalas
            // 
            this.lstsalas.FormattingEnabled = true;
            this.lstsalas.ItemHeight = 20;
            this.lstsalas.Location = new System.Drawing.Point(-1, 132);
            this.lstsalas.Name = "lstsalas";
            this.lstsalas.Size = new System.Drawing.Size(308, 284);
            this.lstsalas.TabIndex = 1;
            this.lstsalas.SelectedIndexChanged += new System.EventHandler(this.lstsalas_SelectedIndexChanged);
            // 
            // txtnewsala
            // 
            this.txtnewsala.Location = new System.Drawing.Point(-1, 60);
            this.txtnewsala.Name = "txtnewsala";
            this.txtnewsala.Size = new System.Drawing.Size(308, 26);
            this.txtnewsala.TabIndex = 2;
            // 
            // txtch
            // 
            this.txtch.Location = new System.Drawing.Point(-1, 100);
            this.txtch.Name = "txtch";
            this.txtch.Size = new System.Drawing.Size(106, 26);
            this.txtch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "CH";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form04CambiarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtch);
            this.Controls.Add(this.txtnewsala);
            this.Controls.Add(this.lstsalas);
            this.Controls.Add(this.btncambiar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form04CambiarSala";
            this.Text = "Form04CambiarSala";
            this.Load += new System.EventHandler(this.Form04CambiarSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.ListBox lstsalas;
        private System.Windows.Forms.TextBox txtnewsala;
        private System.Windows.Forms.TextBox txtch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}