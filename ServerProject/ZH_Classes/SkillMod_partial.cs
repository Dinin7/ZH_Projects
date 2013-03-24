using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH_Classes {
	public partial class SkillMod {
		public virtual ModAttributeType ModAttributeType {
			get{
				return (ModAttributeType)Enum.ToObject(typeof(ModAttributeType), ModAttributeTypeValue);
			}
			set{
				ModAttributeTypeValue = (int)value;
			}
		}

		public virtual ModType ModType {
			get {
				return (ModType)Enum.ToObject(typeof(ModType), ModTypeValue);
			}
			set {
				ModTypeValue = (int)value;
			}
		}
	}
}
