
namespace CSharpInicio
{
    partial class Index
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
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnOpRel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al proyecto de C# en escritorio, aqui se mostrara las habilidades que " +
    "aprendi en esta plataforma.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa tu nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseWaitCursor = true;
            // 
            // txtNameUser
            // 
            this.txtNameUser.Location = new System.Drawing.Point(213, 149);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(100, 20);
            this.txtNameUser.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.flowLayoutPanel1.Controls.Add(this.btnCalculadora);
            this.flowLayoutPanel1.Controls.Add(this.btnOpRel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(360, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(374, 197);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Location = new System.Drawing.Point(3, 3);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(75, 23);
            this.btnCalculadora.TabIndex = 0;
            this.btnCalculadora.Text = "&Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoEllipsis = true;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFecha.Location = new System.Drawing.Point(9, 183);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 26);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.UseWaitCursor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoEllipsis = true;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblDate.Location = new System.Drawing.Point(87, 183);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 26);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Fecha";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDate.UseWaitCursor = true;
            this.lblDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnOpRel
            // 
            this.btnOpRel.Location = new System.Drawing.Point(84, 3);
            this.btnOpRel.Name = "btnOpRel";
            this.btnOpRel.Size = new System.Drawing.Size(78, 38);
            this.btnOpRel.TabIndex = 1;
            this.btnOpRel.Text = "&Operadores relacionales";
            this.btnOpRel.UseVisualStyleBackColor = true;
            this.btnOpRel.Click += new System.EventHandler(this.btnOpRel_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 227);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtNameUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "Index";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtNameUser;
        private System.Windows.Forms.Button btnOpRel;
    }
}

