using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
	public partial class Form1 : Form
	{
		TcpClient tcp_client = new TcpClient();
		ASCIIEncoding encoder = new ASCIIEncoding();
		NetworkStream stream = null;
		byte[] buffer;
		string message = "";

		public Form1()
		{
			InitializeComponent();
		}

		private void btnConectar_Click(object sender, EventArgs e)
		{
			btnConectar.Enabled = false;
			if (Txt_servidor.Text == "")
			{
				MessageBox.Show("Por favor ingrese una dirección IP para el servidor", "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				if (!tcp_client.Connected)
				{
					try
					{
						tcp_client = new TcpClient();
						IPEndPoint server_end_point = new IPEndPoint(IPAddress.Parse(Txt_servidor.Text), 30000);

						tcp_client.Connect(server_end_point);
						NetworkStream client_stream = tcp_client.GetStream();
						buffer = encoder.GetBytes("Hello Server");
						client_stream.Write(buffer, 0, buffer.Length);
						client_stream.Flush();
						byte[] message2 = new byte[4096];
						int bytesRead = client_stream.Read(message2, 0, 4096);

						MessageBox.Show("Conexión realizada con éxito");

					}
					catch (Exception excep)
					{
						MessageBox.Show(excep.ToString());
					}
				}
				else
				{
					try
					{
						tcp_client.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.ToString());
					}
				}
			}
		}//conectar

		private void btnDesconectar_Click(object sender, EventArgs e)
		{
			btnConectar.Enabled = true;
			Txt_servidor.Clear();
			limpia_mensajes_peticion();
			if (tcp_client.Connected)
			{
				try
				{
					tcp_client.Close();
					MessageBox.Show("Desconexión realizada con éxito");

				}
				catch (Exception exc)
				{
					MessageBox.Show(exc.ToString());
				}
			}
		}//desconectar

		private void btnEnviar_Click(object sender, EventArgs e)
		{
			NetworkStream client_stream = tcp_client.GetStream();
			buffer = encoder.GetBytes(Txt_Mensaje.Text.Trim());
			client_stream.Write(buffer, 0, buffer.Length);
			client_stream.Flush();
			byte[] message2 = new byte[4096];
			int bytesRead = client_stream.Read(message2, 0, 4096);
			encoder.GetString(message2, 0, bytesRead);
			Txt_Mensaje.Text = encoder.GetString(message2, 0, bytesRead).ToString();


		}//enviar

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			limpia_mensajes_peticion();
		}//limpiar

		private void limpia_mensajes_peticion()
		{
			Txt_Mensaje.Clear();

		}//proceso limpia mensajes de la caja grande


	}//class
}//namespace
