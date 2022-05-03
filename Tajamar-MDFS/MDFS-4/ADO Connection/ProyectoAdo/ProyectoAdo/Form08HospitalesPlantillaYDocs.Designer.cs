
namespace ProyectoAdo
{
    partial class Form08HospitalesPlantillaYDocs
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
            this.cmbhospis = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstotal = new System.Windows.Forms.TextBox();
            this.txtsmedio = new System.Windows.Forms.TextBox();
            this.txtpersonas = new System.Windows.Forms.TextBox();
            this.lstemples = new System.Windows.Forms.ListView();
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hospital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmbhospis
            // 
            this.cmbhospis.FormattingEnabled = true;
            this.cmbhospis.Location = new System.Drawing.Point(12, 39);
            this.cmbhospis.Name = "cmbhospis";
            this.cmbhospis.Size = new System.Drawing.Size(268, 28);
            this.cmbhospis.TabIndex = 1;
            this.cmbhospis.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salario Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salario Medio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nº Personal";
            // 
            // txtstotal
            // 
            this.txtstotal.Location = new System.Drawing.Point(136, 97);
            this.txtstotal.Name = "txtstotal";
            this.txtstotal.Size = new System.Drawing.Size(144, 26);
            this.txtstotal.TabIndex = 6;
            // 
            // txtsmedio
            // 
            this.txtsmedio.Location = new System.Drawing.Point(136, 132);
            this.txtsmedio.Name = "txtsmedio";
            this.txtsmedio.Size = new System.Drawing.Size(144, 26);
            this.txtsmedio.TabIndex = 7;
            // 
            // txtpersonas
            // 
            this.txtpersonas.Location = new System.Drawing.Point(136, 176);
            this.txtpersonas.Name = "txtpersonas";
            this.txtpersonas.Size = new System.Drawing.Size(144, 26);
            this.txtpersonas.TabIndex = 8;
            // 
            // lstemples
            // 
            this.lstemples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstemples.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Apellido,
            this.Salario,
            this.Hospital});
            this.lstemples.FullRowSelect = true;
            this.lstemples.GridLines = true;
            this.lstemples.HideSelection = false;
            this.lstemples.Location = new System.Drawing.Point(335, 2);
            this.lstemples.Name = "lstemples";
            this.lstemples.Size = new System.Drawing.Size(434, 343);
            this.lstemples.TabIndex = 9;
            this.lstemples.UseCompatibleStateImageBehavior = false;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 200;
            // 
            // Salario
            // 
            this.Salario.Text = "Salario";
            this.Salario.Width = 120;
            // 
            // Hospital
            // 
            this.Hospital.Text = "Hospital";
            this.Hospital.Width = 120;
            // 
            // Form08HospitalesPlantillaYDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 347);
            this.Controls.Add(this.lstemples);
            this.Controls.Add(this.txtpersonas);
            this.Controls.Add(this.txtsmedio);
            this.Controls.Add(this.txtstotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbhospis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form08HospitalesPlantillaYDocs";
            this.Text = "Form08HospitalesPlantillaYDocs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbhospis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstotal;
        private System.Windows.Forms.TextBox txtsmedio;
        private System.Windows.Forms.TextBox txtpersonas;
        private System.Windows.Forms.ListView lstemples;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Salario;
        private System.Windows.Forms.ColumnHeader Hospital;
    }
}