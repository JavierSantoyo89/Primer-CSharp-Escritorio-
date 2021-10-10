
namespace CSharpInicio.OperadoresRelacionales
{
    partial class FrmOpRelacionales
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
            this.lblHola = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMayorIgual = new System.Windows.Forms.Button();
            this.btnMenorIgual = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.btnMayor = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDiferente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Location = new System.Drawing.Point(15, 16);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(32, 13);
            this.lblHola.TabIndex = 23;
            this.lblHola.Text = "Hola ";
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Location = new System.Drawing.Point(74, 16);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(44, 13);
            this.lblNameUser.TabIndex = 22;
            this.lblNameUser.Text = "Nombre";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(160, 161);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(73, 13);
            this.lblResultado.TabIndex = 21;
            this.lblResultado.Text = "___________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Resultado:";
            // 
            // btnMayorIgual
            // 
            this.btnMayorIgual.Location = new System.Drawing.Point(281, 98);
            this.btnMayorIgual.Name = "btnMayorIgual";
            this.btnMayorIgual.Size = new System.Drawing.Size(75, 27);
            this.btnMayorIgual.TabIndex = 19;
            this.btnMayorIgual.Text = ">=";
            this.btnMayorIgual.UseVisualStyleBackColor = true;
            // 
            // btnMenorIgual
            // 
            this.btnMenorIgual.Location = new System.Drawing.Point(281, 69);
            this.btnMenorIgual.Name = "btnMenorIgual";
            this.btnMenorIgual.Size = new System.Drawing.Size(75, 27);
            this.btnMenorIgual.TabIndex = 18;
            this.btnMenorIgual.Text = "<=";
            this.btnMenorIgual.UseVisualStyleBackColor = true;
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(281, 40);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(75, 27);
            this.btnMenor.TabIndex = 17;
            this.btnMenor.Text = "<";
            this.btnMenor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(281, 11);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(75, 27);
            this.btnMayor.TabIndex = 16;
            this.btnMayor.Text = ">";
            this.btnMayor.UseVisualStyleBackColor = true;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(150, 119);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 15;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(150, 71);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 14;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(30, 125);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(56, 13);
            this.lblNum2.TabIndex = 13;
            this.lblNum2.Text = "Numero 2:";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(30, 77);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(56, 13);
            this.lblNum1.TabIndex = 12;
            this.lblNum1.Text = "Numero 1:";
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(281, 131);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 27);
            this.btnIgual.TabIndex = 24;
            this.btnIgual.Text = "==";
            this.btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnDiferente
            // 
            this.btnDiferente.Location = new System.Drawing.Point(281, 161);
            this.btnDiferente.Name = "btnDiferente";
            this.btnDiferente.Size = new System.Drawing.Size(75, 27);
            this.btnDiferente.TabIndex = 25;
            this.btnDiferente.Text = "!=";
            this.btnDiferente.UseVisualStyleBackColor = true;
            // 
            // FrmOpRelacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(379, 214);
            this.Controls.Add(this.btnDiferente);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.lblHola);
            this.Controls.Add(this.lblNameUser);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMayorIgual);
            this.Controls.Add(this.btnMenorIgual);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "FrmOpRelacionales";
            this.Text = "FrmOpRelacionales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOpRelacionales_FormClosing);
            this.Load += new System.EventHandler(this.FrmOpRelacionales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblHola;
        public System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMayorIgual;
        private System.Windows.Forms.Button btnMenorIgual;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDiferente;
    }
}