namespace migracion_2020
{
	partial class Transaccion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaccion));
			this.label1 = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
			this.label1.Location = new System.Drawing.Point(22, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(377, 56);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tipo de Trámite";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNom
			// 
			this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNom.Location = new System.Drawing.Point(167, 163);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(300, 20);
			this.txtNom.TabIndex = 15;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(32, 256);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(333, 36);
			this.button1.TabIndex = 18;
			this.button1.Text = "Continuar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1_Click_1);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackgroundImage = global::migracion_2020.Properties.Resources.button_round;
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox4.Location = new System.Drawing.Point(22, 243);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(354, 62);
			this.pictureBox4.TabIndex = 17;
			this.pictureBox4.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DimGray;
			this.label2.Location = new System.Drawing.Point(28, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(284, 88);
			this.label2.TabIndex = 20;
			this.label2.Text = "Seleccione un tipo de Tramite:\r\n\r\n\r\n\r\n";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Mayor de edad",
            "Menor de edad",
            "Adulto Mayor (Mayor de 60 Años)"});
			this.comboBox1.Location = new System.Drawing.Point(57, 139);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(290, 27);
			this.comboBox1.TabIndex = 21;
			this.comboBox1.Text = "Tipo de Pasaporte";
			// 
			// Transaccion
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(415, 338);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Transaccion";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inicio_FormClosed);
			this.Load += new System.EventHandler(this.Inicio_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}