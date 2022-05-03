
namespace Fundamentos
{
    partial class Form19MetodosEventosColecciones
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbxasociar = new System.Windows.Forms.CheckBox();
            this.lbleventos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cbxasociar
            // 
            this.cbxasociar.AutoSize = true;
            this.cbxasociar.Location = new System.Drawing.Point(12, 299);
            this.cbxasociar.Name = "cbxasociar";
            this.cbxasociar.Size = new System.Drawing.Size(165, 28);
            this.cbxasociar.TabIndex = 3;
            this.cbxasociar.Text = "Asociar Eventos";
            this.cbxasociar.UseVisualStyleBackColor = true;
            this.cbxasociar.CheckedChanged += new System.EventHandler(this.cbxasociar_CheckedChanged);
            // 
            // lbleventos
            // 
            this.lbleventos.AutoSize = true;
            this.lbleventos.Location = new System.Drawing.Point(42, 250);
            this.lbleventos.Name = "lbleventos";
            this.lbleventos.Size = new System.Drawing.Size(83, 24);
            this.lbleventos.TabIndex = 4;
            this.lbleventos.Text = "Eventos:";
            // 
            // Form19MetodosEventosColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 358);
            this.Controls.Add(this.lbleventos);
            this.Controls.Add(this.cbxasociar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form19MetodosEventosColecciones";
            this.Text = "Form19MetodosEventosColecciones";
            this.Load += new System.EventHandler(this.Form19MetodosEventosColecciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cbxasociar;
        private System.Windows.Forms.Label lbleventos;
    }
}