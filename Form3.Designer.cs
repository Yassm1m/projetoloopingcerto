namespace ProjetoLooping
{
    partial class frmposto
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
            this.Calcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblposto = new System.Windows.Forms.Label();
            this.lbllitro = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtposto = new System.Windows.Forms.TextBox();
            this.txtlitro = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(34, 242);
            this.Calcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(88, 29);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(157, 242);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(88, 29);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(325, 242);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(88, 29);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblposto
            // 
            this.lblposto.AutoSize = true;
            this.lblposto.Location = new System.Drawing.Point(31, 55);
            this.lblposto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblposto.Name = "lblposto";
            this.lblposto.Size = new System.Drawing.Size(318, 16);
            this.lblposto.TabIndex = 3;
            this.lblposto.Text = "Digite \'G\' se deseja colocar gasolina ou \'A\'para álcool:";
            // 
            // lbllitro
            // 
            this.lbllitro.AutoSize = true;
            this.lbllitro.Location = new System.Drawing.Point(31, 113);
            this.lbllitro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllitro.Name = "lbllitro";
            this.lbllitro.Size = new System.Drawing.Size(154, 16);
            this.lbllitro.TabIndex = 4;
            this.lbllitro.Text = "Quantidade litros deseja?";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(31, 166);
            this.lblresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(62, 16);
            this.lblresult.TabIndex = 5;
            this.lblresult.Text = "O valor é:";
            // 
            // txtposto
            // 
            this.txtposto.Location = new System.Drawing.Point(357, 55);
            this.txtposto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtposto.Name = "txtposto";
            this.txtposto.Size = new System.Drawing.Size(122, 22);
            this.txtposto.TabIndex = 6;
            // 
            // txtlitro
            // 
            this.txtlitro.Location = new System.Drawing.Point(186, 110);
            this.txtlitro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtlitro.Name = "txtlitro";
            this.txtlitro.Size = new System.Drawing.Size(98, 22);
            this.txtlitro.TabIndex = 7;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(110, 166);
            this.txtresult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(135, 22);
            this.txtresult.TabIndex = 8;
            // 
            // frmposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtlitro);
            this.Controls.Add(this.txtposto);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbllitro);
            this.Controls.Add(this.lblposto);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.Calcular);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmposto";
            this.Text = "Posto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblposto;
        private System.Windows.Forms.Label lbllitro;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtposto;
        private System.Windows.Forms.TextBox txtlitro;
        private System.Windows.Forms.TextBox txtresult;
    }
}