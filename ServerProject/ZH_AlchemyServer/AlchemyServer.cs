using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using Alchemy;
using Alchemy.Classes;
using System.Threading;

namespace ZH_AlchemyServer {
	public partial class AlchemyServer : ServiceBase {
		WebSocketServer _wsServer;


		public AlchemyServer() {
			InitializeComponent();
		}

		protected override void OnStart(string[] args) {
			for (int i = 0; i < 100; i++) {
				Thread.Sleep(1000);
			}

			//Debugger.Launch();
			//while (!Debugger.IsAttached) {
			//    Thread.Sleep(1000);
			//}

			// Initialize the server on port 54321, accept any IPs, and bind events.
			_wsServer = new WebSocketServer(54321, IPAddress.Any) {
				OnReceive = OnReceive,
				OnSend = OnSend,
				OnConnected = OnConnect,
				OnDisconnect = OnDisconnect,
				TimeOut = new TimeSpan(0, 5, 0)
			};
			_wsServer.Start();
		}

		protected override void OnStop() {
			_wsServer.Stop();
		}

		/// <summary>
		/// Event fired when a client connects to the Alchemy Websockets server instance.
		/// Adds the client to the online users list.
		/// </summary>
		/// <param name="context">The user's connection context</param>
		public static void OnConnect(UserContext context) {
			Console.WriteLine("Client Connection From : " + context.ClientAddress);
		}

		/// <summary>
		/// Event fired when a data is received from the Alchemy Websockets server instance.
		/// Parses data as JSON and calls the appropriate message or sends an error message.
		/// </summary>
		/// <param name="context">The user's connection context</param>
		public static void OnReceive(UserContext context) {
			Console.WriteLine("Received Data From :" + context.ClientAddress);

			try {
				var json = context.DataFrame.ToString();

				// <3 dynamics
				dynamic obj = JsonConvert.DeserializeObject(json);


			} catch (Exception e) {// Bad JSON! For shame.
				var r = new Response { Type = ResponseType.Error, Data = new { e.Message } };
				context.Send(JsonConvert.SerializeObject(r));
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
		}


		/// <summary>
		/// Defines the type of response to send back to the client for parsing logic
		/// </summary>
		public enum ResponseType {
			Connection = 0,
			Disconnect = 1,
			Message = 2,
			Error = 255
		}

		/// <summary>
		/// Defines the response object to send back to the client
		/// </summary>
		public class Response {
			public ResponseType Type { get; set; }
			public dynamic Data { get; set; }
		}
	}
}
