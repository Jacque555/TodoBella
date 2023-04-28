namespace Presentacion.TodaBella
{
    partial class FrmAgendamientoAdd
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
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtHora
            // 
            this.TxtHora.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F);
            this.TxtHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(102)))), ((int)(((byte)(118)))));
            this.TxtHora.Location = new System.Drawing.Point(732, 561);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(397, 43);
            this.TxtHora.TabIndex = 92;
            this.TxtHora.Text = "HH:MM";
            // 
            // TxtFecha
            // 
            this.TxtFecha.BackColor = System.Drawing.Color.White;
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F);
            this.TxtFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(102)))), ((int)(((byte)(118)))));
            this.TxtFecha.Location = new System.Drawing.Point(161, 561);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(400, 43);
            this.TxtFecha.TabIndex = 91;
            this.TxtFecha.Text = "AAAA/MM/DD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(189)))), ((int)(((byte)(195)))));
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F);
            this.label3.Location = new System.Drawing.Point(155, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 35);
            this.label3.TabIndex = 90;
            this.label3.Text = "Servicio:";
            // 
            // cmbServicio
            // 
            this.cmbServicio.BackColor = System.Drawing.Color.White;
            this.cmbServicio.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F);
            this.cmbServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(102)))), ((int)(((byte)(118)))));
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Items.AddRange(new object[] {
            "Depilación",
            "Moldeado",
            "Eliminación de tatuaje",
            "Faciales"});
            this.cmbServicio.Location = new System.Drawing.Point(161, 421);
            this.cmbServicio.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(968, 42);
            this.cmbServicio.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(189)))), ((int)(((byte)(195)))));
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F);
            this.label4.Location = new System.Drawing.Point(726, 496);
            this.label4.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 35);
            this.label4.TabIndex = 88;
            this.label4.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(189)))), ((int)(((byte)(195)))));
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F);
            this.label2.Location = new System.Drawing.Point(155, 496);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 35);
            this.label2.TabIndex = 87;
            this.label2.Text = "Fecha:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.White;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F);
            this.cmbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(102)))), ((int)(((byte)(118)))));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(161, 300);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(968, 42);
            this.cmbCliente.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(189)))), ((int)(((byte)(195)))));
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 16.2F);
            this.label7.Location = new System.Drawing.Point(155, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 35);
            this.label7.TabIndex = 86;
            this.label7.Text = "Cliente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.TodaBella.Properties.Resources.Captura_de_pantalla_2023_04_24_195747;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1307, 805);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(165)))), ((int)(((byte)(228)))));
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(991, 671);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 116;
            this.label1.Text = "REGISTRAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(165)))), ((int)(((byte)(228)))));
            this.pictureBox3.Image = global::Presentacion.TodaBella.Properties.Resources.Captura_de_pantalla_2023_04_24_202719;
            this.pictureBox3.Location = new System.Drawing.Point(973, 656);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 117;
            this.pictureBox3.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(165)))), ((int)(((byte)(228)))));
            this.lblMenu.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Black;
            this.lblMenu.Location = new System.Drawing.Point(799, 671);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(73, 25);
            this.lblMenu.TabIndex = 114;
            this.lblMenu.Text = "MENÚ";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(165)))), ((int)(((byte)(228)))));
            this.pictureBox2.Image = global::Presentacion.TodaBella.Properties.Resources.Captura_de_pantalla_2023_04_24_202719;
            this.pictureBox2.Location = new System.Drawing.Point(759, 656);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 115;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(102)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(551, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 42);
            this.label5.TabIndex = 118;
            this.label5.Text = "AGENDAR";
            // 
            // FrmAgendamientoAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1305, 800);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtHora);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgendamientoAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgendamientoAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}