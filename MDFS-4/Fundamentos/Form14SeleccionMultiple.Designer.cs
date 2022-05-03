
namespace Fundamentos
{
    partial class Form14SeleccionMultiple
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
            this.btnseleccionados = new System.Windows.Forms.Button();
            this.txtelemento = new System.Windows.Forms.TextBox();
            this.lblseleccionados = new System.Windows.Forms.Label();
            this.lblindices = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstelementos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnseleccionados
            // 
            this.btnseleccionados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnseleccionados.Location = new System.Drawing.Point(255, 198);
            this.btnseleccionados.Name = "btnseleccionados";
            this.btnseleccionados.Size = new System.Drawing.Size(174, 49);
            this.btnseleccionados.TabIndex = 28;
            this.btnseleccionados.Text = "Seleccionados";
            this.btnseleccionados.UseVisualStyleBackColor = false;
            this.btnseleccionados.Click += new System.EventHandler(this.btnseleccionados_Click);
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(255, 39);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(174, 26);
            this.txtelemento.TabIndex = 27;
            // 
            // lblseleccionados
            // 
            this.lblseleccionados.AutoSize = true;
            this.lblseleccionados.Location = new System.Drawing.Point(28, 372);
            this.lblseleccionados.Name = "lblseleccionados";
            this.lblseleccionados.Size = new System.Drawing.Size(121, 20);
            this.lblseleccionados.TabIndex = 26;
            this.lblseleccionados.Text = "Seleccionados: ";
            // 
            // lblindices
            // 
            this.lblindices.AutoSize = true;
            this.lblindices.Location = new System.Drawing.Point(28, 348);
            this.lblindices.Name = "lblindices";
            this.lblindices.Size = new System.Drawing.Size(68, 20);
            this.lblindices.TabIndex = 25;
            this.lblindices.Text = "Indices: ";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btneliminar.Location = new System.Drawing.Point(255, 143);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(174, 49);
            this.btneliminar.TabIndex = 24;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btninsert.Location = new System.Drawing.Point(255, 90);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(174, 47);
            this.btninsert.TabIndex = 23;
            this.btninsert.Text = "Insertar";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Elemento";
            // 
            // lstelementos
            // 
            this.lstelementos.FormattingEnabled = true;
            this.lstelementos.ItemHeight = 20;
            this.lstelementos.Location = new System.Drawing.Point(28, 39);
            this.lstelementos.Name = "lstelementos";
            this.lstelementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstelementos.Size = new System.Drawing.Size(199, 284);
            this.lstelementos.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Elementos:";
            // 
            // Form14SeleccionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 409);
            this.Controls.Add(this.btnseleccionados);
            this.Controls.Add(this.txtelemento);
            this.Controls.Add(this.lblseleccionados);
            this.Controls.Add(this.lblindices);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstelementos);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form14SeleccionMultiple";
            this.Text = "Form14SeleccionMultiple";
            this.Load += new System.EventHandler(this.Form14SeleccionMultiple_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnseleccionados;
        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.Label lblseleccionados;
        private System.Windows.Forms.Label lblindices;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstelementos;
        private System.Windows.Forms.Label label4;
    }
}