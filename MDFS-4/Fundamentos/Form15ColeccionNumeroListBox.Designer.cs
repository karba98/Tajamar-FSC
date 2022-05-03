
namespace Fundamentos
{
    partial class Form15ColeccionNumeroListBox
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
            this.lstnumeros = new System.Windows.Forms.ListBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.btnmostrardatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.txtpares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtimpares = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnseleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeros";
            // 
            // lstnumeros
            // 
            this.lstnumeros.FormattingEnabled = true;
            this.lstnumeros.ItemHeight = 24;
            this.lstnumeros.Location = new System.Drawing.Point(23, 61);
            this.lstnumeros.Name = "lstnumeros";
            this.lstnumeros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstnumeros.Size = new System.Drawing.Size(222, 412);
            this.lstnumeros.TabIndex = 1;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(264, 61);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(182, 65);
            this.btngenerar.TabIndex = 2;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // btnmostrardatos
            // 
            this.btnmostrardatos.Location = new System.Drawing.Point(264, 151);
            this.btnmostrardatos.Name = "btnmostrardatos";
            this.btnmostrardatos.Size = new System.Drawing.Size(182, 65);
            this.btnmostrardatos.TabIndex = 3;
            this.btnmostrardatos.Text = "Mostrar datos";
            this.btnmostrardatos.UseVisualStyleBackColor = true;
            this.btnmostrardatos.Click += new System.EventHandler(this.btnmostrardatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suma";
            // 
            // txtsuma
            // 
            this.txtsuma.Location = new System.Drawing.Point(346, 348);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.Size = new System.Drawing.Size(100, 29);
            this.txtsuma.TabIndex = 5;
            // 
            // txtpares
            // 
            this.txtpares.Location = new System.Drawing.Point(346, 396);
            this.txtpares.Name = "txtpares";
            this.txtpares.Size = new System.Drawing.Size(100, 29);
            this.txtpares.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pares";
            // 
            // txtimpares
            // 
            this.txtimpares.Location = new System.Drawing.Point(346, 441);
            this.txtimpares.Name = "txtimpares";
            this.txtimpares.Size = new System.Drawing.Size(100, 29);
            this.txtimpares.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Impares";
            // 
            // btnseleccionados
            // 
            this.btnseleccionados.Location = new System.Drawing.Point(264, 235);
            this.btnseleccionados.Name = "btnseleccionados";
            this.btnseleccionados.Size = new System.Drawing.Size(182, 65);
            this.btnseleccionados.TabIndex = 10;
            this.btnseleccionados.Text = "Mostrar datos Seleccionados";
            this.btnseleccionados.UseVisualStyleBackColor = true;
            this.btnseleccionados.Click += new System.EventHandler(this.btnseleccionados_Click);
            // 
            // Form15ColeccionNumeroListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 491);
            this.Controls.Add(this.btnseleccionados);
            this.Controls.Add(this.txtimpares);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmostrardatos);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.lstnumeros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form15ColeccionNumeroListBox";
            this.Text = "Form15ColeccionNumeroListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstnumeros;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btnmostrardatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsuma;
        private System.Windows.Forms.TextBox txtpares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtimpares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnseleccionados;
    }
}