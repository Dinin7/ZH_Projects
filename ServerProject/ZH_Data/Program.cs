using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using ZH_Classes;
using Zh_BL;

namespace ZH_Data {
	class Program {
		static void Main(string[] args) {
			ImportSkills();
		}

		static private void ImportSkills() {
			FileStream importData = File.Open(@"..\..\ImportData\ImportData.xml", FileMode.Open);
			XmlDocument doc = new XmlDocument();
			doc.Load(importData);

			foreach (XmlNode nd in doc.SelectNodes("ImportData/Skills/Skill")) {
				Skill skill = new Skill();
				skill.SkillName = nd.SelectSingleNode("Name").InnerText;
				skill.Skillpoints = (int)GetIntValue(nd, "Skillpoints");
				//skill.SkillpointsMultiplier = (int)GetIntValue(nd,"SkillpointsMultiplier");
				skill.PreAttention = GetIntValue(nd, "PreAttention");
				skill.PreDexterity = GetIntValue(nd, "PreDexterity");
				skill.PreIntelligence = GetIntValue(nd, "PreIntelligence");
				//skill.PreSkillid1 = GetIntValue(nd, "PreSkillid1");
				//skill.PreSkillid2 = GetIntValue(nd, "PreSkillid2");
				skill.PreSkillLevel1 = GetIntValue(nd, "PreSkillLevel1");
				skill.PreSkillLevel2 = GetIntValue(nd, "PreSkillLevel2");
				skill.PreStrenght = GetIntValue(nd, "PreStrenght");
				foreach (XmlNode ndMod in nd.SelectNodes("Mods/Mod")) {
					SkillMod mod = new SkillMod();
					mod.ModAttributeType = (ModAttributeType)Enum.Parse(typeof(ModAttributeType), ndMod.SelectSingleNode("ModAttributeType").InnerText);
					mod.ModType = (ModType)Enum.Parse(typeof(ModType), ndMod.SelectSingleNode("ModType").InnerText);
					mod.Modifier = (int)GetIntValue(ndMod, "Modifier");
				}
			}
		}

		static int? GetIntValue(XmlNode nd, string name) {
			if (nd.SelectSingleNode(name) == null)
				return null;
			return Convert.ToInt32(nd.SelectSingleNode(name));
		}
	}
}
