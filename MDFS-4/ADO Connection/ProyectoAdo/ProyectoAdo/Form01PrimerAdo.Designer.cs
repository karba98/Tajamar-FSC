
namespace ProyectoAdo
{
    partial class Form01PrimerAdo
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
            this.btnconnect = new System.Windows.Forms.Button();
            this.btndisconnect = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.lstapellidos = new System.Windows.Forms.ListBox();
            this.lstcolumnas = new System.Windows.Forms.ListBox();
            this.lsttipos = new System.Windows.Forms.ListBox();
            this.lblstate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(12, 68);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(161, 49);
            this.btnconnect.TabIndex = 0;
            this.btnconnect.Text = "Conectar";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // btndisconnect
            // 
            this.btndisconnect.Location = new System.Drawing.Point(12, 123);
            this.btndisconnect.Name = "btndisconnect";
            this.btndisconnect.Size = new System.Drawing.Size(161, 49);
            this.btndisconnect.TabIndex = 1;
            this.btndisconnect.Text = "Desconectar";
            this.btndisconnect.UseVisualStyleBackColor = true;
            this.btndisconnect.Click += new System.EventHandler(this.btndisconnect_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(12, 178);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(161, 49);
            this.btnread.TabIndex = 2;
            this.btnread.Text = "Leer datos";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // lstapellidos
            // 
            this.lstapellidos.FormattingEnabled = true;
            this.lstapellidos.ItemHeight = 24;
            this.lstapellidos.Location = new System.Drawing.Point(179, 66);
            this.lstapellidos.Name = "lstapellidos";
            this.lstapellidos.Size = new System.Drawing.Size(167, 364);
            this.lstapellidos.TabIndex = 3;
            // 
            // lstcolumnas
            // 
            this.lstcolumnas.FormattingEnabled = true;
            this.lstcolumnas.ItemHeight = 24;
            this.lstcolumnas.Location = new System.Drawing.Point(352, 66);
            this.lstcolumnas.Name = "lstcolumnas";
            this.lstcolumnas.Size = new System.Drawing.Size(167, 364);
            this.lstcolumnas.TabIndex = 4;
            // 
            // lsttipos
            // 
            this.lsttipos.FormattingEnabled = true;
            this.lsttipos.ItemHeight = 24;
            this.lsttipos.Location = new System.Drawing.Point(525, 66);
            this.lsttipos.Name = "lsttipos";
            this.lsttipos.Size = new System.Drawing.Size(167, 364);
            this.lsttipos.TabIndex = 5;
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Location = new System.Drawing.Point(32, 406);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(69, 24);
            this.lblstate.TabIndex = 6;
            this.lblstate.Text = "Closed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Columnas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipos";
            // 
            // Form01PrimerAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblstate);
            this.Controls.Add(this.lsttipos);
            this.Controls.Add(this.lstcolumnas);
            this.Controls.Add(this.lstapellidos);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btndisconnect);
            this.Controls.Add(this.btnconnect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form01PrimerAdo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Button btndisconnect;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.ListBox lstapellidos;
        private System.Windows.Forms.ListBox lstcolumnas;
        private System.Windows.Forms.ListBox lsttipos;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

