namespace Servidor
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
			this.label1 = new System.Windows.Forms.Label();
			this.Txt_Mensajes = new System.Windows.Forms.RichTextBox();
			this.Txt_clientes = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.95F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(86, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clientes conectados";
			// 
			// Txt_Mensajes
			// 
			this.Txt_Mensajes.BackColor = System.Drawing.Color.Black;
			this.Txt_Mensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_Mensajes.ForeColor = System.Drawing.Color.White;
			this.Txt_Mensajes.Location = new System.Drawing.Point(13, 120);
			this.Txt_Mensajes.Name = "Txt_Mensajes";
			this.Txt_Mensajes.ReadOnly = true;
			this.Txt_Mensajes.Size = new System.Drawing.Size(775, 303);
			this.Txt_Mensajes.TabIndex = 1;
			this.Txt_Mensajes.Text = "";
			// 
			// Txt_clientes
			// 
			this.Txt_clientes.BackColor = System.Drawing.Color.Black;
			this.Txt_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Txt_clientes.ForeColor = System.Drawing.Color.White;
			this.Txt_clientes.Location = new System.Drawing.Point(383, 60);
			this.Txt_clientes.Name = "Txt_clientes";
			this.Txt_clientes.ReadOnly = true;
			this.Txt_clientes.Size = new System.Drawing.Size(100, 31);
			this.Txt_clientes.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(601, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(187, 60);
			this.label2.TabIndex = 3;
			this.label2.Text = "1 euro = 650 colones\r\n1 dólar US = 550 colones\r\n1 yuan = 80 colones";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Txt_clientes);
			this.Controls.Add(this.Txt_Mensajes);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Servidor";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox Txt_Mensajes;
		private System.Windows.Forms.TextBox Txt_clientes;
		private System.Windows.Forms.Label label2;
	}
}

