using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using ZH_Classes;
using Alchemy.Classes;
using Newtonsoft.Json;
using ZH_Classes.Classes;


namespace Zh_BL {
	public class WSCommunication {

		ConcurrentDictionary<MyUserContext, string> OnlineUsers = new ConcurrentDictionary<MyUserContext, string>();
		private DataManager dm = new DataManager();

		public void OnConnect(UserContext context) {
			Console.WriteLine("Client Connection From : " + context.ClientAddress);

			MyUserContext myUserContext = new MyUserContext(new User(), context);
			OnlineUsers.TryAdd(myUserContext, String.Empty);
		}

		public void OnReceive(UserContext context) {
			MyUserContext u = OnlineUsers.Keys.Where(o => o.UserContext.ClientAddress == context.ClientAddress).Single();
			var json = context.DataFrame.ToString();
			
			WSCommInfo obj = (WSCommInfo)JsonConvert.DeserializeObject(json, typeof(WSCommInfo));
			switch (obj.WSCommInfo_ActionType) {
				case WSAction.Login:
					User tempUser = (User)JsonConvert.DeserializeObject(json, typeof(User));
					User user = dm.GetUser(tempUser.Username);
					
					obj.WSCommInfo_ActionType = WSAction.LoginComplete;
					if (user == null || user.Passwrd != tempUser.Passwrd) {
						obj.WSCommInfo_ErrorType = WSActionError.LoginError;
					} else {
						// Login succesfull -> take user
						u.User = user;
						obj.WSCommInfo_ErrorType = WSActionError.NONE;
					}
					StringBuilder sb = new StringBuilder();
					sb.Append(JsonConvert.SerializeObject(obj));
					
					if (obj.WSCommInfo_ErrorType == WSActionError.NONE)
						sb.Append(JsonConvert.SerializeObject(user));
					u.UserContext.Send(sb.ToString());

					break;
				default:
					break;
			}

		}

		public void OnDisconnect(UserContext context) {

		}

		public void Send(UserContext uc, WSCommInfo wsci, Object o){
			StringBuilder sb = new StringBuilder();
			//if (o != null) {
			//    sb.Append(JsonConvert.SerializeObject(o));
			//    sb.Insert(sb.Length-1, Json
			//}
		}
	}

	
}
