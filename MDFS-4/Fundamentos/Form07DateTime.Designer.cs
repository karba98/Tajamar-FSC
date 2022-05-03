
namespace Fundamentos
{
    partial class Form07DateTime
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
            this.txtfechaactual = new System.Windows.Forms.TextBox();
            this.cbxcambiarformato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxdia = new System.Windows.Forms.CheckBox();
            this.cbxmes = new System.Windows.Forms.CheckBox();
            this.cbxanyo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmostrarr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnuevafecha = new System.Windows.Forms.TextBox();
            this.lbldatos = new System.Windows.Forms.Label();
            this.txtincremento = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Actual";
            // 
            // txtfechaactual
            // 
            this.txtfechaactual.Location = new System.Drawing.Point(54, 50);
            this.txtfechaactual.Name = "txtfechaactual";
            this.txtfechaactual.Size = new System.Drawing.Size(268, 20);
            this.txtfechaactual.TabIndex = 1;
            this.txtfechaactual.TextChanged += new System.EventHandler(this.txtfechaactual_TextChanged);
            // 
            // cbxcambiarformato
            // 
            this.cbxcambiarformato.AutoSize = true;
            this.cbxcambiarformato.Location = new System.Drawing.Point(54, 76);
            this.cbxcambiarformato.Name = "cbxcambiarformato";
            this.cbxcambiarformato.Size = new System.Drawing.Size(102, 17);
            this.cbxcambiarformato.TabIndex = 2;
            this.cbxcambiarformato.Text = "Cambiar formato";
            this.cbxcambiarformato.UseVisualStyleBackColor = true;
            this.cbxcambiarformato.CheckedChanged += new System.EventHandler(this.cbxcambiarformato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txtincremento);
            this.groupBox1.Controls.Add(this.btnmostrarr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxanyo);
            this.groupBox1.Controls.Add(this.cbxmes);
            this.groupBox1.Controls.Add(this.cbxdia);
            this.groupBox1.Location = new System.Drawing.Point(54, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones Fecha";
            // 
            // cbxdia
            // 
            this.cbxdia.AutoSize = true;
            this.cbxdia.Location = new System.Drawing.Point(20, 30);
            this.cbxdia.Name = "cbxdia";
            this.cbxdia.Size = new System.Drawing.Size(49, 17);
            this.cbxdia.TabIndex = 0;
            this.cbxdia.Text = "Días";
            this.cbxdia.UseVisualStyleBackColor = true;
            // 
            // cbxmes
            // 
            this.cbxmes.AutoSize = true;
            this.cbxmes.Location = new System.Drawing.Point(20, 54);
            this.cbxmes.Name = "cbxmes";
            this.cbxmes.Size = new System.Drawing.Size(57, 17);
            this.cbxmes.TabIndex = 1;
            this.cbxmes.Text = "Meses";
            this.cbxmes.UseVisualStyleBackColor = true;
            // 
            // cbxanyo
            // 
            this.cbxanyo.AutoSize = true;
            this.cbxanyo.Location = new System.Drawing.Point(20, 78);
            this.cbxanyo.Name = "cbxanyo";
            this.cbxanyo.Size = new System.Drawing.Size(50, 17);
            this.cbxanyo.TabIndex = 2;
            this.cbxanyo.Text = "Años";
            this.cbxanyo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // btnmostrarr
            // 
            this.btnmostrarr.Location = new System.Drawing.Point(150, 78);
            this.btnmostrarr.Name = "btnmostrarr";
            this.btnmostrarr.Size = new System.Drawing.Size(100, 23);
            this.btnmostrarr.TabIndex = 4;
            this.btnmostrarr.Text = "Mostrar fecha";
            this.btnmostrarr.UseVisualStyleBackColor = true;
            this.btnmostrarr.Click += new System.EventHandler(this.btnmostrarr_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva fecha";
            // 
            // txtnuevafecha
            // 
            this.txtnuevafecha.Location = new System.Drawing.Point(51, 280);
            this.txtnuevafecha.Name = "txtnuevafecha";
            this.txtnuevafecha.Size = new System.Drawing.Size(271, 20);
            this.txtnuevafecha.TabIndex = 5;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatos.ForeColor = System.Drawing.Color.Red;
            this.lbldatos.Location = new System.Drawing.Point(51, 336);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(0, 22);
            this.lbldatos.TabIndex = 6;
            // 
            // txtincremento
            // 
            this.txtincremento.Location = new System.Drawing.Point(150, 47);
            this.txtincremento.Name = "txtincremento";
            this.txtincremento.Size = new System.Drawing.Size(100, 20);
            this.txtincremento.TabIndex = 5;
            // 
            // Form07DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 428);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.txtnuevafecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxcambiarformato);
            this.Controls.Add(this.txtfechaactual);
            this.Controls.Add(this.label1);
            this.Name = "Form07DateTime";
            this.Text = "Form07DateTime";
            this.Load += new System.EventHandler(this.Form07DateTime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfechaactual;
        private System.Windows.Forms.CheckBox cbxcambiarformato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtincremento;
        private System.Windows.Forms.Button btnmostrarr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxanyo;
        private System.Windows.Forms.CheckBox cbxmes;
        private System.Windows.Forms.CheckBox cbxdia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnuevafecha;
        private System.Windows.Forms.Label lbldatos;
    }
}