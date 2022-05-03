
namespace ProyectoAdo
{
    partial class Form09Enfermos
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
            this.lsvenfermos = new System.Windows.Forms.ListView();
            this.INSCRIPCION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FECHA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GENERO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DIRECCION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NSS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvenfermos
            // 
            this.lsvenfermos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.INSCRIPCION,
            this.Apellido,
            this.DIRECCION,
            this.FECHA,
            this.GENERO,
            this.NSS});
            this.lsvenfermos.ForeColor = System.Drawing.Color.Gray;
            this.lsvenfermos.FullRowSelect = true;
            this.lsvenfermos.GridLines = true;
            this.lsvenfermos.HideSelection = false;
            this.lsvenfermos.Location = new System.Drawing.Point(-1, 2);
            this.lsvenfermos.Name = "lsvenfermos";
            this.lsvenfermos.Size = new System.Drawing.Size(821, 328);
            this.lsvenfermos.TabIndex = 0;
            this.lsvenfermos.UseCompatibleStateImageBehavior = false;
            this.lsvenfermos.View = System.Windows.Forms.View.Details;
            this.lsvenfermos.SelectedIndexChanged += new System.EventHandler(this.lsvenfermos_SelectedIndexChanged);
            // 
            // INSCRIPCION
            // 
            this.INSCRIPCION.Text = "INSCRIPCION";
            this.INSCRIPCION.Width = 146;
            // 
            // Apellido
            // 
            this.Apellido.Text = "APELLIDO";
            this.Apellido.Width = 144;
            // 
            // FECHA
            // 
            this.FECHA.DisplayIndex = 2;
            this.FECHA.Text = "FECHA";
            this.FECHA.Width = 139;
            // 
            // GENERO
            // 
            this.GENERO.DisplayIndex = 3;
            this.GENERO.Text = "GENERO";
            this.GENERO.Width = 152;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DisplayIndex = 4;
            this.DIRECCION.Text = "DIRECCION";
            this.DIRECCION.Width = 93;
            // 
            // NSS
            // 
            this.NSS.Text = "NSS";
            this.NSS.Width = 132;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(-1, 336);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 70);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Borrar";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form09Enfermos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(819, 406);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.lsvenfermos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form09Enfermos";
            this.Text = "Form09Enfermos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvenfermos;
        private System.Windows.Forms.ColumnHeader INSCRIPCION;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader DIRECCION;
        private System.Windows.Forms.ColumnHeader FECHA;
        private System.Windows.Forms.ColumnHeader GENERO;
        private System.Windows.Forms.ColumnHeader NSS;
        private System.Windows.Forms.Button btndelete;
    }
}