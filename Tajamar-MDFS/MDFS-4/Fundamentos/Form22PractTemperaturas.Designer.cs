
namespace Fundamentos
{
    partial class Form22PractTemperaturas
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
            this.lstmonths = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmeses = new System.Windows.Forms.Button();
            this.btndatos = new System.Windows.Forms.Button();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstmonths
            // 
            this.lstmonths.FormattingEnabled = true;
            this.lstmonths.ItemHeight = 24;
            this.lstmonths.Location = new System.Drawing.Point(29, 54);
            this.lstmonths.Name = "lstmonths";
            this.lstmonths.Size = new System.Drawing.Size(292, 364);
            this.lstmonths.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meses";
            // 
            // btnmeses
            // 
            this.btnmeses.Location = new System.Drawing.Point(351, 54);
            this.btnmeses.Name = "btnmeses";
            this.btnmeses.Size = new System.Drawing.Size(196, 61);
            this.btnmeses.TabIndex = 2;
            this.btnmeses.Text = "Generar meses";
            this.btnmeses.UseVisualStyleBackColor = true;
            this.btnmeses.Click += new System.EventHandler(this.btnmeses_Click);
            // 
            // btndatos
            // 
            this.btndatos.Location = new System.Drawing.Point(351, 137);
            this.btndatos.Name = "btndatos";
            this.btndatos.Size = new System.Drawing.Size(196, 61);
            this.btndatos.TabIndex = 3;
            this.btndatos.Text = "Mostrar datos";
            this.btndatos.UseVisualStyleBackColor = true;
            this.btndatos.Click += new System.EventHandler(this.btndatos_Click);
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(447, 251);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(100, 29);
            this.txtmax.TabIndex = 4;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(447, 312);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(100, 29);
            this.txtmin.TabIndex = 5;
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(447, 372);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(100, 29);
            this.txtmedia.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Máxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Media";
            // 
            // Form22PractTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 479);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.btndatos);
            this.Controls.Add(this.btnmeses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstmonths);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form22PractTemperaturas";
            this.Text = "Form22PractTemperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstmonths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmeses;
        private System.Windows.Forms.Button btndatos;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}