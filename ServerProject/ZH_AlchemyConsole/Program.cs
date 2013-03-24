using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alchemy;
using System.Net;
using Alchemy.Classes;
using Zh_BL;
using ZH_Classes;

namespace ZH_AlchemyConsole {
	class Program {

		static WSCommunication comm;

		static void Main(string[] args) {
			try {

				DataManager dm = new DataManager();
				// Initialize the server on port 81, accept any IPs, and bind events.
				var aServer = new WebSocketServer(54321, IPAddress.Any) {
					OnReceive = OnReceive,
					OnSend = OnSend,
					OnConnected = OnConnect,
					OnDisconnect = OnDisconnect,
					TimeOut = new TimeSpan(0, 5, 0)
				};

				aServer.Start();

				comm = new WSCommunication();

				// Accept commands on the console and keep it alive
				var command = string.Empty;
				while (command != "exit") {
					command = Console.ReadLine();
				}

				aServer.Stop();
			} catch (Exception e) {
				Console.WriteLine(e.ToString());
				Console.ReadLine();
			}
		}

		/// <summary>
		/// Event fired when a client connects to the Alchemy Websockets server instance.
		/// Adds the client to the online users list.
		/// </summary>
		/// <param name="context">The user's connection context</param>
		public static void OnConnect(UserContext context) {
			Console.WriteLine("Client Connection From : " + context.ClientAddress);
			comm.OnConnect(context);
		}

		/// <summary>
		/// Event fired when a data is received from the Alchemy Websockets server instance.
		/// Parses data as JSON and calls the appropriate message or sends an error message.
		/// </summary>
		/// <param name="context">The user's connection context</param>
		public static void OnReceive(UserContext context) {
			try {
				Console.WriteLine("Received Data From :" + context.ClientAddress);
				comm.OnReceive(context);
			} catch (Exception e) {
				Console.WriteLine(e.ToString());
				Console.ReadLine();
			}
		}

		/// <summary>
		/// Event fired when the Alchemy Websockets server instance sends data to a client.
		/// Logs the data to the console and performs no further action.
		/// </summary>
		/// <param name="context">The user's connection context</param>
		public static void OnSend(UserContext context) {
			Console.WriteLine("Data Send To : " + context.ClientAddress);
		}

		/// <summary>
		/// Event fired when a client disconnects from the Alchemy Websockets server instance.
		/// Removes the user from the online users list and broadcasts the disconnection message
		/// to all connected users.
		/// </summary>
		/// <param name="context">The user's connection context</param>
		public static void OnDisconnect(UserContext context) {
			Console.WriteLine("Client Disconnected : " + context.ClientAddress);

			comm.OnDisconnect(context);
		}
	}
}
