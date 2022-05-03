
namespace ProyectoAdo
{
    partial class Form11HospitalesPlantilla
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
            this.panel = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lsvPlantilla = new System.Windows.Forms.ListView();
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Funcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hospital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Silver;
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(430, 401);
            this.panel.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(430, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 401);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lsvPlantilla
            // 
            this.lsvPlantilla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Apellido,
            this.Funcion,
            this.Salario,
            this.Hospital});
            this.lsvPlantilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvPlantilla.FullRowSelect = true;
            this.lsvPlantilla.GridLines = true;
            this.lsvPlantilla.HideSelection = false;
            this.lsvPlantilla.Location = new System.Drawing.Point(433, 0);
            this.lsvPlantilla.Name = "lsvPlantilla";
            this.lsvPlantilla.Size = new System.Drawing.Size(511, 401);
            this.lsvPlantilla.TabIndex = 2;
            this.lsvPlantilla.UseCompatibleStateImageBehavior = false;
            this.lsvPlantilla.View = System.Windows.Forms.View.Details;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 165;
            // 
            // Funcion
            // 
            this.Funcion.Text = "Funcion";
            this.Funcion.Width = 143;
            // 
            // Salario
            // 
            this.Salario.Text = "Salario";
            this.Salario.Width = 89;
            // 
            // Hospital
            // 
            this.Hospital.Text = "Hospital";
            this.Hospital.Width = 104;
            // 
            // Form11HospitalesPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 401);
            this.Controls.Add(this.lsvPlantilla);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form11HospitalesPlantilla";
            this.Text = "Form11HospitalesPlantilla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lsvPlantilla;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Funcion;
        private System.Windows.Forms.ColumnHeader Salario;
        private System.Windows.Forms.ColumnHeader Hospital;
    }
}