namespace Presentacion.TodaBella
{
    partial class FrmAgendamiento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgAgendamiento = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(200)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(7, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 126);
            this.panel1.TabIndex = 19;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(817, 0);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(66, 59);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(266, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALOJAMIENTOS";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(215)))), ((int)(((byte)(212)))));
            this.btnAgregar.Location = new System.Drawing.Point(804, 197);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 51);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            this.txtBuscar.Location = new System.Drawing.Point(211, 201);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(575, 22);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Alojamiento:";
            // 
            // dtgAgendamiento
            // 
            this.dtgAgendamiento.AllowUserToAddRows = false;
            this.dtgAgendamiento.AllowUserToDeleteRows = false;
            this.dtgAgendamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(225)))));
            this.dtgAgendamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgendamiento.Location = new System.Drawing.Point(18, 258);
            this.dtgAgendamiento.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.dtgAgendamiento.Name = "dtgAgendamiento";
            this.dtgAgendamiento.ReadOnly = true;
            this.dtgAgendamiento.RowHeadersWidth = 51;
            this.dtgAgendamiento.RowTemplate.Height = 24;
            this.dtgAgendamiento.Size = new System.Drawing.Size(849, 216);
            this.dtgAgendamiento.TabIndex = 15;
            this.dtgAgendamiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgendamiento_CellClick);
            this.dtgAgendamiento.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgendamiento_CellEnter);
            // 
            // FrmAgendamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgAgendamiento);
            this.Name = "FrmAgendamiento";
            this.Text = "FrmAgendamiento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgendamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgAgendamiento;
    }
}