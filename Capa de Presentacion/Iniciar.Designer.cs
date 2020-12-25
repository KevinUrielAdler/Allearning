
namespace Capa_de_Presentacion
{
    partial class Iniciar
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
            this.salir = new System.Windows.Forms.Button();
            this.entrar = new System.Windows.Forms.Button();
            this.contralogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(251, 122);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(85, 50);
            this.salir.TabIndex = 17;
            this.salir.Text = "Cancelar";
            this.salir.UseVisualStyleBackColor = true;
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(17, 122);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(85, 50);
            this.entrar.TabIndex = 16;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // contralogin
            // 
            this.contralogin.Location = new System.Drawing.Point(160, 76);
            this.contralogin.Name = "contralogin";
            this.contralogin.PasswordChar = '*';
            this.contralogin.Size = new System.Drawing.Size(176, 20);
            this.contralogin.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contraseña:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(112, 35);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(224, 20);
            this.login.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.BackColor = System.Drawing.Color.Transparent;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Id.ForeColor = System.Drawing.Color.White;
            this.Id.Location = new System.Drawing.Point(12, 26);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(102, 29);
            this.Id.TabIndex = 12;
            this.Id.Text = "Usuario:";
            // 
            // Iniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(351, 189);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.contralogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Id);
            this.Name = "Iniciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.TextBox contralogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label Id;
    }
}