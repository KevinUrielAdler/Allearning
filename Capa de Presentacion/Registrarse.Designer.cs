
namespace Capa_de_Presentacion
{
    partial class Registrarse
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
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.atras = new System.Windows.Forms.Button();
            this.registroo = new System.Windows.Forms.Button();
            this.contraaconn = new System.Windows.Forms.TextBox();
            this.contra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfirmcontr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(122, 132);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(364, 20);
            this.email.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Email:";
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(218, 185);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(85, 50);
            this.atras.TabIndex = 22;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // registroo
            // 
            this.registroo.Location = new System.Drawing.Point(31, 185);
            this.registroo.Name = "registroo";
            this.registroo.Size = new System.Drawing.Size(85, 50);
            this.registroo.TabIndex = 21;
            this.registroo.Text = "Registrar";
            this.registroo.UseVisualStyleBackColor = true;
            this.registroo.Click += new System.EventHandler(this.registroo_Click);
            // 
            // contraaconn
            // 
            this.contraaconn.Location = new System.Drawing.Point(122, 91);
            this.contraaconn.Name = "contraaconn";
            this.contraaconn.PasswordChar = '*';
            this.contraaconn.Size = new System.Drawing.Size(364, 20);
            this.contraaconn.TabIndex = 20;
            // 
            // contra
            // 
            this.contra.Location = new System.Drawing.Point(122, 51);
            this.contra.Name = "contra";
            this.contra.PasswordChar = '*';
            this.contra.Size = new System.Drawing.Size(364, 20);
            this.contra.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña:";
            // 
            // nomm
            // 
            this.nomm.Location = new System.Drawing.Point(122, 11);
            this.nomm.Name = "nomm";
            this.nomm.Size = new System.Drawing.Size(364, 20);
            this.nomm.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // lblConfirmcontr
            // 
            this.lblConfirmcontr.AutoSize = true;
            this.lblConfirmcontr.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmcontr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblConfirmcontr.ForeColor = System.Drawing.Color.White;
            this.lblConfirmcontr.Location = new System.Drawing.Point(12, 86);
            this.lblConfirmcontr.Name = "lblConfirmcontr";
            this.lblConfirmcontr.Size = new System.Drawing.Size(96, 24);
            this.lblConfirmcontr.TabIndex = 25;
            this.lblConfirmcontr.Text = "Confirmar:";
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(498, 248);
            this.Controls.Add(this.lblConfirmcontr);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.registroo);
            this.Controls.Add(this.contraaconn);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomm);
            this.Controls.Add(this.label1);
            this.Name = "Registrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button registroo;
        private System.Windows.Forms.TextBox contraaconn;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfirmcontr;
    }
}