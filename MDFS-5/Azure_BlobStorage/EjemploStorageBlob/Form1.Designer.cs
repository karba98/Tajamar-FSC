
namespace EjemploStorageBlob
{
    partial class Form1
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
            this.txtContenedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncreateContainer = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.lsvBlob = new System.Windows.Forms.ListView();
            this.Uri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listContenedores = new System.Windows.Forms.ListBox();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContenedor
            // 
            this.txtContenedor.Location = new System.Drawing.Point(158, 31);
            this.txtContenedor.Name = "txtContenedor";
            this.txtContenedor.Size = new System.Drawing.Size(224, 31);
            this.txtContenedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contenedor";
            // 
            // btncreateContainer
            // 
            this.btncreateContainer.Location = new System.Drawing.Point(33, 86);
            this.btncreateContainer.Name = "btncreateContainer";
            this.btncreateContainer.Size = new System.Drawing.Size(349, 52);
            this.btncreateContainer.TabIndex = 2;
            this.btncreateContainer.Text = "Crear Contenedor";
            this.btncreateContainer.UseVisualStyleBackColor = true;
            this.btncreateContainer.Click += new System.EventHandler(this.btncreateContainer_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(33, 156);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(349, 47);
            this.btnSubir.TabIndex = 3;
            this.btnSubir.Text = "Subir Blob";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // lsvBlob
            // 
            this.lsvBlob.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Uri,
            this.Size});
            this.lsvBlob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBlob.HideSelection = false;
            this.lsvBlob.Location = new System.Drawing.Point(31, 294);
            this.lsvBlob.Name = "lsvBlob";
            this.lsvBlob.Size = new System.Drawing.Size(684, 240);
            this.lsvBlob.TabIndex = 5;
            this.lsvBlob.UseCompatibleStateImageBehavior = false;
            this.lsvBlob.View = System.Windows.Forms.View.Details;
            this.lsvBlob.SelectedIndexChanged += new System.EventHandler(this.lsvBlob_SelectedIndexChanged);
            // 
            // Uri
            // 
            this.Uri.Text = "Uri";
            this.Uri.Width = 238;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Size.Width = 444;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contenedores";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(738, 68);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(484, 466);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // listContenedores
            // 
            this.listContenedores.FormattingEnabled = true;
            this.listContenedores.ItemHeight = 25;
            this.listContenedores.Location = new System.Drawing.Point(405, 86);
            this.listContenedores.Name = "listContenedores";
            this.listContenedores.Size = new System.Drawing.Size(310, 179);
            this.listContenedores.TabIndex = 9;
            this.listContenedores.SelectedIndexChanged += new System.EventHandler(this.listContenedores_SelectedIndexChanged);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(33, 218);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(349, 47);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Eliminar Blob";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 557);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.listContenedores);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsvBlob);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.btncreateContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContenedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncreateContainer;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.ListView lsvBlob;
        private System.Windows.Forms.ColumnHeader Uri;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox listContenedores;
        private System.Windows.Forms.Button btndelete;
    }
}

