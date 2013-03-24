using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alchemy.Classes;

namespace ZH_Classes.Classes {
	public class MyUserContext {
		public User User;
		public UserContext UserContext;

		public MyUserContext(User user, UserContext userContext) {
			User = user;
			UserContext = userContext;
		}
	}
}
