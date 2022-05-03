
namespace ProyectoAdo
{
    partial class Form10ClasesEmpleado
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
            this.lsvempleados = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboficios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtincrementos = new System.Windows.Forms.TextBox();
            this.btnincrement = new System.Windows.Forms.Button();
            this.Nemple = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvempleados
            // 
            this.lsvempleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nemple,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvempleados.ForeColor = System.Drawing.Color.Gray;
            this.lsvempleados.GridLines = true;
            this.lsvempleados.HideSelection = false;
            this.lsvempleados.Location = new System.Drawing.Point(319, 0);
            this.lsvempleados.Name = "lsvempleados";
            this.lsvempleados.Size = new System.Drawing.Size(646, 368);
            this.lsvempleados.TabIndex = 0;
            this.lsvempleados.UseCompatibleStateImageBehavior = false;
            this.lsvempleados.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oficios";
            // 
            // cmboficios
            // 
            this.cmboficios.FormattingEnabled = true;
            this.cmboficios.Location = new System.Drawing.Point(77, 11);
            this.cmboficios.Name = "cmboficios";
            this.cmboficios.Size = new System.Drawing.Size(221, 28);
            this.cmboficios.TabIndex = 2;
            this.cmboficios.SelectedIndexChanged += new System.EventHandler(this.cmboficios_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // txtincrementos
            // 
            this.txtincrementos.Location = new System.Drawing.Point(114, 60);
            this.txtincrementos.Name = "txtincrementos";
            this.txtincrementos.Size = new System.Drawing.Size(184, 26);
            this.txtincrementos.TabIndex = 4;
            // 
            // btnincrement
            // 
            this.btnincrement.Location = new System.Drawing.Point(17, 103);
            this.btnincrement.Name = "btnincrement";
            this.btnincrement.Size = new System.Drawing.Size(281, 38);
            this.btnincrement.TabIndex = 5;
            this.btnincrement.Text = "Aumentar Salario";
            this.btnincrement.UseVisualStyleBackColor = true;
            this.btnincrement.Click += new System.EventHandler(this.btnincrement_Click);
            // 
            // Nemple
            // 
            this.Nemple.Text = "NºEmpleado";
            this.Nemple.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            this.columnHeader2.Width = 186;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oficio";
            this.columnHeader3.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Salario";
            this.columnHeader4.Width = 95;
            // 
            // Form10ClasesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 366);
            this.Controls.Add(this.btnincrement);
            this.Controls.Add(this.txtincrementos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboficios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvempleados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form10ClasesEmpleado";
            this.Text = "Form10ClasesEmpleado";
            this.Load += new System.EventHandler(this.Form10ClasesEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvempleados;
        private System.Windows.Forms.ColumnHeader Nemple;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboficios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtincrementos;
        private System.Windows.Forms.Button btnincrement;
    }
}