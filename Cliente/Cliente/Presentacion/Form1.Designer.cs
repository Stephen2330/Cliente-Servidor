namespace Cliente
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Txt_servidor = new System.Windows.Forms.TextBox();
			this.btnConectar = new System.Windows.Forms.Button();
			this.btnDesconectar = new System.Windows.Forms.Button();
			this.Txt_Mensaje = new System.Windows.Forms.RichTextBox();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Txt_servidor
			// 
			this.Txt_servidor.BackColor = System.Drawing.Color.Black;
			this.Txt_servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_servidor.ForeColor = System.Drawing.Color.White;
			this.Txt_servidor.Location = new System.Drawing.Point(12, 36);
			this.Txt_servidor.Name = "Txt_servidor";
			this.Txt_servidor.Size = new System.Drawing.Size(522, 35);
			this.Txt_servidor.TabIndex = 0;
			// 
			// btnConectar
			// 
			this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConectar.Location = new System.Drawing.Point(559, 36);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(104, 35);
			this.btnConectar.TabIndex = 1;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// btnDesconectar
			// 
			this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDesconectar.Location = new System.Drawing.Point(683, 36);
			this.btnDesconectar.Name = "btnDesconectar";
			this.btnDesconectar.Size = new System.Drawing.Size(105, 35);
			this.btnDesconectar.TabIndex = 2;
			this.btnDesconectar.Text = "Desconectar";
			this.btnDesconectar.UseVisualStyleBackColor = true;
			this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
			// 
			// Txt_Mensaje
			// 
			this.Txt_Mensaje.BackColor = System.Drawing.Color.Black;
			this.Txt_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_Mensaje.ForeColor = System.Drawing.Color.White;
			this.Txt_Mensaje.Location = new System.Drawing.Point(13, 77);
			this.Txt_Mensaje.Name = "Txt_Mensaje";
			this.Txt_Mensaje.Size = new System.Drawing.Size(776, 321);
			this.Txt_Mensaje.TabIndex = 3;
			this.Txt_Mensaje.Text = "";
			// 
			// btnEnviar
			// 
			this.btnEnviar.BackColor = System.Drawing.Color.Black;
			this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnviar.Location = new System.Drawing.Point(696, 404);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(92, 40);
			this.btnEnviar.TabIndex = 4;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.UseVisualStyleBackColor = false;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.Black;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(583, 404);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(94, 40);
			this.btnLimpiar.TabIndex = 5;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEnviar);
			this.Controls.Add(this.Txt_Mensaje);
			this.Controls.Add(this.btnDesconectar);
			this.Controls.Add(this.btnConectar);
			this.Controls.Add(this.Txt_servidor);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Txt_servidor;
		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.Button btnDesconectar;
		private System.Windows.Forms.RichTextBox Txt_Mensaje;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.Button btnLimpiar;
	}
}

