
namespace Fundamentos
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
            this.btnpulsa = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnpulsa
            // 
            this.btnpulsa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnpulsa.Location = new System.Drawing.Point(32, 111);
            this.btnpulsa.Name = "btnpulsa";
            this.btnpulsa.Size = new System.Drawing.Size(97, 37);
            this.btnpulsa.TabIndex = 0;
            this.btnpulsa.Text = "Pulsar";
            this.btnpulsa.UseVisualStyleBackColor = false;
            this.btnpulsa.Click += new System.EventHandler(this.btnpulsa_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(91, 51);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(131, 20);
            this.txtbox.TabIndex = 1;
            this.txtbox.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.btnpulsa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpulsa;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Label label1;
    }
}

