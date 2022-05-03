
namespace ProyectoAdo
{
    partial class Form06MensajesServidor
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
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtloc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.lstdept = new System.Windows.Forms.ListBox();
            this.lstnom = new System.Windows.Forms.ListBox();
            this.lstloc = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(17, 48);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(117, 26);
            this.txtnum.TabIndex = 2;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(17, 109);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(257, 26);
            this.txtnom.TabIndex = 3;
            // 
            // txtloc
            // 
            this.txtloc.Location = new System.Drawing.Point(17, 175);
            this.txtloc.Name = "txtloc";
            this.txtloc.Size = new System.Drawing.Size(257, 26);
            this.txtloc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Localidad";
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(17, 221);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(89, 33);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "Insertar";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(17, 276);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(100, 20);
            this.lblmessage.TabIndex = 7;
            this.lblmessage.Text = "DBMensajes";
            // 
            // lstdept
            // 
            this.lstdept.FormattingEnabled = true;
            this.lstdept.ItemHeight = 20;
            this.lstdept.Location = new System.Drawing.Point(306, 52);
            this.lstdept.Name = "lstdept";
            this.lstdept.Size = new System.Drawing.Size(70, 344);
            this.lstdept.TabIndex = 8;
            this.lstdept.SelectedIndexChanged += new System.EventHandler(this.lstdept_SelectedIndexChanged);
            // 
            // lstnom
            // 
            this.lstnom.FormattingEnabled = true;
            this.lstnom.ItemHeight = 20;
            this.lstnom.Location = new System.Drawing.Point(372, 52);
            this.lstnom.Name = "lstnom";
            this.lstnom.Size = new System.Drawing.Size(213, 344);
            this.lstnom.TabIndex = 9;
            this.lstnom.SelectedIndexChanged += new System.EventHandler(this.lstnom_SelectedIndexChanged);
            // 
            // lstloc
            // 
            this.lstloc.FormattingEnabled = true;
            this.lstloc.ItemHeight = 20;
            this.lstloc.Location = new System.Drawing.Point(583, 52);
            this.lstloc.Name = "lstloc";
            this.lstloc.Size = new System.Drawing.Size(201, 344);
            this.lstloc.TabIndex = 10;
            this.lstloc.SelectedIndexChanged += new System.EventHandler(this.lstloc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(652, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Localidad";
            // 
            // Form06MensajesServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 413);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstloc);
            this.Controls.Add(this.lstnom);
            this.Controls.Add(this.lstdept);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtloc);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form06MensajesServidor";
            this.Text = "Form06MensajesServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtloc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.ListBox lstdept;
        private System.Windows.Forms.ListBox lstnom;
        private System.Windows.Forms.ListBox lstloc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}