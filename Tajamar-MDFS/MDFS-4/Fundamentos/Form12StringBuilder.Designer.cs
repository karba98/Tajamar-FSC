
namespace Fundamentos
{
    partial class Form12StringBuilder
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
            this.txttexto = new System.Windows.Forms.RichTextBox();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.btnreverse = new System.Windows.Forms.Button();
            this.btnreverseB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(22, 39);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(328, 262);
            this.txttexto.TabIndex = 1;
            this.txttexto.Text = "";
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Location = new System.Drawing.Point(18, 323);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(85, 24);
            this.lbltiempo.TabIndex = 2;
            this.lbltiempo.Text = "Tiempo: ";
            // 
            // btnreverse
            // 
            this.btnreverse.Location = new System.Drawing.Point(367, 39);
            this.btnreverse.Name = "btnreverse";
            this.btnreverse.Size = new System.Drawing.Size(239, 40);
            this.btnreverse.TabIndex = 3;
            this.btnreverse.Text = "Reverse String";
            this.btnreverse.UseVisualStyleBackColor = true;
            this.btnreverse.Click += new System.EventHandler(this.btnreverse_Click);
            // 
            // btnreverseB
            // 
            this.btnreverseB.Location = new System.Drawing.Point(367, 103);
            this.btnreverseB.Name = "btnreverseB";
            this.btnreverseB.Size = new System.Drawing.Size(239, 40);
            this.btnreverseB.TabIndex = 4;
            this.btnreverseB.Text = "Reverse String builder";
            this.btnreverseB.UseVisualStyleBackColor = true;
            this.btnreverseB.Click += new System.EventHandler(this.btnreverseB_Click);
            // 
            // Form12StringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 380);
            this.Controls.Add(this.btnreverseB);
            this.Controls.Add(this.btnreverse);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form12StringBuilder";
            this.Text = "Form12StringBuilder";
            this.Load += new System.EventHandler(this.Form12StringBuilder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txttexto;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Button btnreverse;
        private System.Windows.Forms.Button btnreverseB;
    }
}