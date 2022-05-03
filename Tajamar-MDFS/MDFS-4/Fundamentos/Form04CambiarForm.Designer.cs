
namespace Fundamentos
{
    partial class Form04CambiarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.txtrojo = new System.Windows.Forms.TextBox();
            this.txtverde = new System.Windows.Forms.TextBox();
            this.txtazul = new System.Windows.Forms.TextBox();
            this.btnposicion = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posicion X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posicion Y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rojo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Verde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Azul";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(125, 45);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(100, 20);
            this.txtx.TabIndex = 5;
            this.txtx.TextChanged += new System.EventHandler(this.txtx_TextChanged);
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(125, 104);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(100, 20);
            this.txty.TabIndex = 6;
            this.txty.TextChanged += new System.EventHandler(this.txty_TextChanged);
            // 
            // txtrojo
            // 
            this.txtrojo.Location = new System.Drawing.Point(391, 46);
            this.txtrojo.Name = "txtrojo";
            this.txtrojo.Size = new System.Drawing.Size(100, 20);
            this.txtrojo.TabIndex = 7;
            this.txtrojo.TextChanged += new System.EventHandler(this.txtrojo_TextChanged);
            // 
            // txtverde
            // 
            this.txtverde.Location = new System.Drawing.Point(391, 104);
            this.txtverde.Name = "txtverde";
            this.txtverde.Size = new System.Drawing.Size(100, 20);
            this.txtverde.TabIndex = 8;
            this.txtverde.TextChanged += new System.EventHandler(this.txtverde_TextChanged);
            // 
            // txtazul
            // 
            this.txtazul.Location = new System.Drawing.Point(391, 165);
            this.txtazul.Name = "txtazul";
            this.txtazul.Size = new System.Drawing.Size(100, 20);
            this.txtazul.TabIndex = 9;
            this.txtazul.TextChanged += new System.EventHandler(this.txtazul_TextChanged);
            // 
            // btnposicion
            // 
            this.btnposicion.Location = new System.Drawing.Point(110, 223);
            this.btnposicion.Name = "btnposicion";
            this.btnposicion.Size = new System.Drawing.Size(115, 41);
            this.btnposicion.TabIndex = 10;
            this.btnposicion.Text = "Posicion";
            this.btnposicion.UseVisualStyleBackColor = true;
            this.btnposicion.Click += new System.EventHandler(this.btnposicion_Click);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(376, 223);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(115, 41);
            this.btncolor.TabIndex = 11;
            this.btncolor.Text = "Color";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Texto de prueba ";
            // 
            // Form04CambiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 443);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnposicion);
            this.Controls.Add(this.txtazul);
            this.Controls.Add(this.txtverde);
            this.Controls.Add(this.txtrojo);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form04CambiarForm";
            this.Text = "Form04CambiarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.TextBox txtrojo;
        private System.Windows.Forms.TextBox txtverde;
        private System.Windows.Forms.TextBox txtazul;
        private System.Windows.Forms.Button btnposicion;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.Label label6;
    }
}