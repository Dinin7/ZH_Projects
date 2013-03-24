using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH_Classes.Classes {
	public class WSCommInfo {
		public String WSCommInfo_ClassType;
		public WSAction WSCommInfo_ActionType;
		public WSActionError WSCommInfo_ErrorType;
		public ZHBase WSCommInfo_Object;
	}

	public enum WSAction{
		Login = 1,
		LoginComplete = 2
	}
	public enum WSActionError {
		NONE = 0,
		LoginError = 1
	}
}
