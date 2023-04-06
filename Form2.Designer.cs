namespace ProjetoLooping
{
    partial class frmlooping
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lbltab = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txttab = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(51, 204);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 51);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Calcular\r\nEnquanto\r\n\r\n";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(169, 204);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 50);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Calcular\r\nPara\r\n";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(294, 203);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 51);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Calcular\r\nRepita\r\n";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lbltab
            // 
            this.lbltab.AutoSize = true;
            this.lbltab.Location = new System.Drawing.Point(71, 45);
            this.lbltab.Name = "lbltab";
            this.lbltab.Size = new System.Drawing.Size(149, 13);
            this.lbltab.TabIndex = 3;
            this.lbltab.Text = "Digite um numéro da tabuada:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(76, 102);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(50, 13);
            this.lblresult.TabIndex = 4;
            this.lblresult.Text = "resultado";
            // 
            // txttab
            // 
            this.txttab.Location = new System.Drawing.Point(224, 45);
            this.txttab.Name = "txttab";
            this.txttab.Size = new System.Drawing.Size(91, 20);
            this.txttab.TabIndex = 5;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(132, 86);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(74, 38);
            this.txtresult.TabIndex = 6;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(104, 260);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 50);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(224, 260);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 50);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmlooping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txttab);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbltab);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "frmlooping";
            this.Text = "Looping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label lbltab;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txttab;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}