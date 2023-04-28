using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
	public partial class Form1 : Form
	{
		int clientesConectados = 0;
		string lastMessage;
		TcpListener tcpListener; //capta metadatos entrantes a través de un socket TCP
		Thread listenThread;

		public Form1()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false; 
			// establece un valor que indica si se detectarán las llamadas en el subproceso equivocado
															 // que tiene acceso a la propiedad Handle de un control
		}//form

		private void Form1_Load(object sender, EventArgs e)
		{
			Txt_Mensajes.Text = "Servidor iniciado, se espera por clientes... \n";
			this.tcpListener = new TcpListener(IPAddress.Any, 30000);
			this.listenThread = new Thread(new ThreadStart(ListenForClients));
			this.listenThread.Start();

		}//Load

		private void ListenForClients()
		{
			this.tcpListener.Start();
			while (true)
			{
				TcpClient client = this.tcpListener.AcceptTcpClient();
				//solicita datos de un recurso de Internet mediante TCP

				clientesConectados++;

				if (InvokeRequired)	
				{
					Invoke(new Action(() => Txt_clientes.Text = clientesConectados.ToString()));
					Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
					clientThread.Start(client);
				}//if
			}//while
		}//Clientes

		private void HandleClientComm(object client)
		{
			TcpClient tcpClient = (TcpClient)client;
			NetworkStream clientStream = tcpClient.GetStream(); //Proporciona el flujo de datos subyacente para el acceso a través de la red.
			ASCIIEncoding encoder = new ASCIIEncoding(); //codificacion ASCII desde bytes
			byte[] message = new byte[4096];
			int bytesRead;
			while (true)
			{
				bytesRead = 0;
				try
				{
					bytesRead = clientStream.Read(message, 0, 4096);
				}
				catch (Exception)
				{
					//error
					throw;
				}//try catch
				if (bytesRead == 0)
				{
					clientesConectados--;
					//if
					if (InvokeRequired)
					{
						Invoke(new Action(() => Txt_clientes.Text = clientesConectados.ToString()));
					}
					break;
				}

				System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));
				lastMessage = encoder.GetString(message, 0, bytesRead);

				if (InvokeRequired)
				{
					Invoke(new Action(() => Txt_Mensajes.Text = "\n" + lastMessage));
					int opcion = Validar_Peticion(Txt_Mensajes.Text);
					byte[] buffer = new byte[4096];

					switch (Txt_Mensajes.Text.Trim())
					{
						case "001 10000":
							buffer = encoder.GetBytes("El monto de 10.000 euros es de: 6.500.000 colones");
							clientStream.Write(buffer, 0, buffer.Length);
							clientStream.Flush(); //	Vacía los datos de la secuencia
							break;
						case "002 10000":
							buffer = encoder.GetBytes("El monto de 10.000 dolares es de: 5.500.000 colones");
							clientStream.Write(buffer, 0, buffer.Length);
							clientStream.Flush();
							break;
						case "003 10000":
							buffer = encoder.GetBytes("El monto de 10.000 yuanes es de: 800.000 colones");
							clientStream.Write(buffer, 0, buffer.Length);
							clientStream.Flush();
							break;
						default:
							buffer = encoder.GetBytes("Invalida");
							clientStream.Write(buffer, 0, buffer.Length);
							clientStream.Flush();
							break;
					}//switch-case
				}//if
			}//while
		}//HandleComm

		public int Validar_Peticion(string peticion)
		{
			switch (peticion)
			{
				case "001 10000":
					return 1;
				case "002 10000":
					return 2;
				case "003 10000":
					return 3;
				default:
					return -1;
			}
		}


	}//class
}//namespace
