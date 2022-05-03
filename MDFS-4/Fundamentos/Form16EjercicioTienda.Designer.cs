
namespace Fundamentos
{
    partial class Form16EjercicioTienda
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
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.lsttienda = new System.Windows.Forms.ListBox();
            this.lstalmacen = new System.Windows.Forms.ListBox();
            this.btntodos = new System.Windows.Forms.Button();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.btnsubir = new System.Windows.Forms.Button();
            this.btnbajar = new System.Windows.Forms.Button();
            this.btntodost = new System.Windows.Forms.Button();
            this.btnseleccioandost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(35, 72);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(125, 26);
            this.txtproducto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(35, 131);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(125, 45);
            this.btninsertar.TabIndex = 2;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.Location = new System.Drawing.Point(35, 182);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(125, 46);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnlimpiar.Location = new System.Drawing.Point(35, 234);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(125, 52);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(35, 292);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(125, 46);
            this.btnmodificar.TabIndex = 5;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // lsttienda
            // 
            this.lsttienda.FormattingEnabled = true;
            this.lsttienda.ItemHeight = 20;
            this.lsttienda.Location = new System.Drawing.Point(191, 73);
            this.lsttienda.Name = "lsttienda";
            this.lsttienda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsttienda.Size = new System.Drawing.Size(183, 264);
            this.lsttienda.TabIndex = 6;
            // 
            // lstalmacen
            // 
            this.lstalmacen.FormattingEnabled = true;
            this.lstalmacen.ItemHeight = 20;
            this.lstalmacen.Location = new System.Drawing.Point(516, 74);
            this.lstalmacen.Name = "lstalmacen";
            this.lstalmacen.Size = new System.Drawing.Size(193, 264);
            this.lstalmacen.TabIndex = 7;
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(389, 204);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(98, 33);
            this.btntodos.TabIndex = 8;
            this.btntodos.Text = "Todos-->";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // btnseleccion
            // 
            this.btnseleccion.Location = new System.Drawing.Point(389, 262);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(98, 33);
            this.btnseleccion.TabIndex = 9;
            this.btnseleccion.Text = "Seleccin-->";
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // btnsubir
            // 
            this.btnsubir.Location = new System.Drawing.Point(733, 131);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(125, 45);
            this.btnsubir.TabIndex = 10;
            this.btnsubir.Text = "Subir";
            this.btnsubir.UseVisualStyleBackColor = true;
            this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
            // 
            // btnbajar
            // 
            this.btnbajar.Location = new System.Drawing.Point(733, 204);
            this.btnbajar.Name = "btnbajar";
            this.btnbajar.Size = new System.Drawing.Size(125, 45);
            this.btnbajar.TabIndex = 11;
            this.btnbajar.Text = "Bajar";
            this.btnbajar.UseVisualStyleBackColor = true;
            this.btnbajar.Click += new System.EventHandler(this.btnbajar_Click);
            // 
            // btntodost
            // 
            this.btntodost.Location = new System.Drawing.Point(389, 94);
            this.btntodost.Name = "btntodost";
            this.btntodost.Size = new System.Drawing.Size(98, 33);
            this.btntodost.TabIndex = 12;
            this.btntodost.Text = "<--Todos";
            this.btntodost.UseVisualStyleBackColor = true;
            this.btntodost.Click += new System.EventHandler(this.btntodost_Click);
            // 
            // btnseleccioandost
            // 
            this.btnseleccioandost.Location = new System.Drawing.Point(389, 143);
            this.btnseleccioandost.Name = "btnseleccioandost";
            this.btnseleccioandost.Size = new System.Drawing.Size(98, 33);
            this.btnseleccioandost.TabIndex = 13;
            this.btnseleccioandost.Text = "<--Seleccin";
            this.btnseleccioandost.UseVisualStyleBackColor = true;
            this.btnseleccioandost.Click += new System.EventHandler(this.btnseleccioandost_Click);
            // 
            // Form16EjercicioTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 394);
            this.Controls.Add(this.btnseleccioandost);
            this.Controls.Add(this.btntodost);
            this.Controls.Add(this.btnbajar);
            this.Controls.Add(this.btnsubir);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.lstalmacen);
            this.Controls.Add(this.lsttienda);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtproducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form16EjercicioTienda";
            this.Text = "Form16EjercicioTienda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.ListBox lsttienda;
        private System.Windows.Forms.ListBox lstalmacen;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.Button btnseleccion;
        private System.Windows.Forms.Button btnsubir;
        private System.Windows.Forms.Button btnbajar;
        private System.Windows.Forms.Button btntodost;
        private System.Windows.Forms.Button btnseleccioandost;
    }
}