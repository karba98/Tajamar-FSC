
namespace ProyectoAdo
{
    partial class Form07ParametrosSalida
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
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsumasal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstemples = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DEPT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmbdept
            // 
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Location = new System.Drawing.Point(131, 13);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(287, 28);
            this.cmbdept.TabIndex = 0;
            this.cmbdept.SelectedIndexChanged += new System.EventHandler(this.cmbdept_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Departamento";
            // 
            // txtsumasal
            // 
            this.txtsumasal.Location = new System.Drawing.Point(131, 61);
            this.txtsumasal.Name = "txtsumasal";
            this.txtsumasal.Size = new System.Drawing.Size(100, 26);
            this.txtsumasal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suma salarial";
            // 
            // lstemples
            // 
            this.lstemples.FormattingEnabled = true;
            this.lstemples.ItemHeight = 20;
            this.lstemples.Location = new System.Drawing.Point(1, 105);
            this.lstemples.Name = "lstemples";
            this.lstemples.Size = new System.Drawing.Size(417, 264);
            this.lstemples.TabIndex = 5;
            this.lstemples.SelectedIndexChanged += new System.EventHandler(this.lstdepts_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Apellido,
            this.DEPT});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(449, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 369);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            // 
            // DEPT
            // 
            this.DEPT.Text = "DEPT";
            // 
            // Form07ParametrosSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 366);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lstemples);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsumasal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbdept);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form07ParametrosSalida";
            this.Text = "Form07ParametrosSalida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsumasal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstemples;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader DEPT;
    }
}