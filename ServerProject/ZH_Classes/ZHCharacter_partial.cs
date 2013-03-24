using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH_Classes {
	partial class ZHCharacter {

		private List<SkillMod> _AllMods;
		public virtual List<SkillMod> AllMods {
			get {
				if (_AllMods == null) {
					_AllMods = new List<SkillMod>();
                    //foreach (Skill skill in this.ColFkChSkillsCharacter1) 
                    //    foreach (Mod mod in skill.ColFkModSkill1) 
                    //        _AllMods.Add(mod);
				}
				return _AllMods;
			}
		}
	}
}
