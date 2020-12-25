
namespace Capa_de_Presentacion
{
    partial class Administrador_Archundia
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
            this.Lbl_HoraFecha = new System.Windows.Forms.Label();
            this.Lbl_NombreAdministrador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TablaData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TablaData)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_HoraFecha
            // 
            this.Lbl_HoraFecha.AutoSize = true;
            this.Lbl_HoraFecha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_HoraFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HoraFecha.ForeColor = System.Drawing.Color.White;
            this.Lbl_HoraFecha.Location = new System.Drawing.Point(755, 9);
            this.Lbl_HoraFecha.Name = "Lbl_HoraFecha";
            this.Lbl_HoraFecha.Size = new System.Drawing.Size(180, 33);
            this.Lbl_HoraFecha.TabIndex = 24;
            this.Lbl_HoraFecha.Text = "Hora y fecha";
            // 
            // Lbl_NombreAdministrador
            // 
            this.Lbl_NombreAdministrador.AutoSize = true;
            this.Lbl_NombreAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NombreAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreAdministrador.ForeColor = System.Drawing.Color.White;
            this.Lbl_NombreAdministrador.Location = new System.Drawing.Point(173, 9);
            this.Lbl_NombreAdministrador.Name = "Lbl_NombreAdministrador";
            this.Lbl_NombreAdministrador.Size = new System.Drawing.Size(196, 33);
            this.Lbl_NombreAdministrador.TabIndex = 23;
            this.Lbl_NombreAdministrador.Text = "Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bienvenido ";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(169, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 38);
            this.button3.TabIndex = 26;
            this.button3.Text = "Cambiar contenido";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 38);
            this.button2.TabIndex = 25;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(818, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TablaData
            // 
            this.TablaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaData.Location = new System.Drawing.Point(28, 54);
            this.TablaData.Name = "TablaData";
            this.TablaData.Size = new System.Drawing.Size(891, 327);
            this.TablaData.TabIndex = 27;
            // 
            // Administrador_Archundia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(957, 461);
            this.Controls.Add(this.TablaData);
            this.Controls.Add(this.Lbl_HoraFecha);
            this.Controls.Add(this.Lbl_NombreAdministrador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Administrador_Archundia";
            this.Text = "Administrador_Archundia";
            this.Load += new System.EventHandler(this.Administrador_Archundia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_HoraFecha;
        private System.Windows.Forms.Label Lbl_NombreAdministrador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TablaData;
    }
}