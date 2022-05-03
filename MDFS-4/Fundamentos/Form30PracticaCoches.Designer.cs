
namespace Fundamentos
{
    partial class Form30PracticaCoches
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
            this.pctcoche = new System.Windows.Forms.PictureBox();
            this.lstcoches = new System.Windows.Forms.ListBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnimage = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctcoche)).BeginInit();
            this.SuspendLayout();
            // 
            // pctcoche
            // 
            this.pctcoche.Location = new System.Drawing.Point(-1, 241);
            this.pctcoche.Name = "pctcoche";
            this.pctcoche.Size = new System.Drawing.Size(316, 243);
            this.pctcoche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctcoche.TabIndex = 0;
            this.pctcoche.TabStop = false;
            // 
            // lstcoches
            // 
            this.lstcoches.FormattingEnabled = true;
            this.lstcoches.ItemHeight = 24;
            this.lstcoches.Location = new System.Drawing.Point(495, 1);
            this.lstcoches.Name = "lstcoches";
            this.lstcoches.Size = new System.Drawing.Size(288, 484);
            this.lstcoches.TabIndex = 1;
            this.lstcoches.SelectedIndexChanged += new System.EventHandler(this.lstcoches_SelectedIndexChanged);
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(-1, 164);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(316, 29);
            this.txtmodelo.TabIndex = 2;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(-1, 126);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(316, 29);
            this.txtmarca.TabIndex = 3;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(312, 241);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(185, 76);
            this.btninsert.TabIndex = 4;
            this.btninsert.Text = "Insertar Coche";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(312, 314);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(185, 76);
            this.btnload.TabIndex = 5;
            this.btnload.Text = "Cargar Coches";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(312, 385);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(185, 99);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Guardar Coches";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Coches";
            // 
            // btnimage
            // 
            this.btnimage.Location = new System.Drawing.Point(312, 202);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(105, 29);
            this.btnimage.TabIndex = 8;
            this.btnimage.Text = "Adjuntar imagen";
            this.btnimage.UseVisualStyleBackColor = true;
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(-1, 202);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(316, 29);
            this.txtpath.TabIndex = 9;
            // 
            // Form30PracticaCoches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 484);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.btnimage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.lstcoches);
            this.Controls.Add(this.pctcoche);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form30PracticaCoches";
            this.Text = "Form30PracticaCoches";
            ((System.ComponentModel.ISupportInitialize)(this.pctcoche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctcoche;
        private System.Windows.Forms.ListBox lstcoches;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnimage;
        private System.Windows.Forms.TextBox txtpath;
    }
}