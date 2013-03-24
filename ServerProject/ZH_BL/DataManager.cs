using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZH_Classes;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace Zh_BL {
	public class DataManager {
		protected ISessionFactory _sFactory = null;
		protected ISessionFactory sFactory {
			get {
				if (_sFactory == null) {

					_sFactory = (new Configuration()).Configure().BuildSessionFactory();

				}

				// Load via fluent -- change to fluent-mappings ??
				//if (_sFactory == null) {
				//    _sFactory = Fluently.Configure().Database(MySQLConfiguration.Standard.ConnectionString("server=localhost;User Id=root;database=zombiehunter;Persist Security Info=True;Password=kasim7")).Mappings(m => m.HbmMappings.AddFromAssemblyOf<Accuracy>()).BuildSessionFactory();
				//}
				return _sFactory;
			}
		}
		#region Character

		public ZHCharacter CreateNewCharacter(User user, string firstName, string lastName) {
			using (ISession session = _sFactory.OpenSession()) {
				ZHCharacter newChar = new ZHCharacter();
				newChar.Caps = 0;
				newChar.Experience = 0;
				newChar.Firstname = firstName;
				newChar.Gender = "M";
				newChar.Lastname = lastName;
				newChar.Level = 1;
				newChar.Skillpoints = 0;
				newChar.TestSpeed = 5;
				//newChar.User = user;

				newChar.Attention = 25;
				newChar.Dexterity = 25;
				newChar.Health = 100;
				newChar.Intelligence = 25;
				newChar.Regeneration = 0;
				newChar.Resistance = 0;
				newChar.Strength = 25;
				newChar.ZombieAttraction = 0;
				newChar.MaxLoad = newChar.Strength;
				RefreshCharacter(newChar);

				session.Save(newChar.ChEffStats);
				session.Save(newChar);
				foreach (int weaponTypeValue in Enum.GetValues(typeof(WeaponType))) {
					Accuracy chAcc = new Accuracy();
					chAcc.AccuracyValue = 50;
					//chAcc.Character = newChar;
					chAcc.WeaponTypeValue = weaponTypeValue;
					//newChar.ColFkChAccuracyCharacter1.Add(chAcc);
					session.Save(chAcc);
				}

				session.Flush();
				return newChar;
			}
		}

		public ZHCharacter GetCharacter(int id) {
			ZHCharacter character = new ZHCharacter();

			using (ISession session = sFactory.OpenSession()) {
				character = session.Get<ZHCharacter>(id);
			}

			return character;
		}

		public IList<ZHCharacter> GetCharacters() {
			using (ISession session = sFactory.OpenSession()) {
				return session.QueryOver<ZHCharacter>().List<ZHCharacter>();
			}
		}

		public void RefreshCharacter(ZHCharacter character) {
			//if (character.ChEffStats == null)
			//    character.ChEffStats = new ChEffStats();

			//character.ChEffStats.EffAttention = character.ChStats.Attention + GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CAtt, ModType.Absolut);
			//character.ChEffStats.EffAttention = character.ChEffStats.EffAttention * (1 + (GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CAtt, ModType.Percent) / 100));

			//character.ChEffStats.EffDexterity = character.ChStats.Dexterity + GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CDex, ModType.Absolut);
			//character.ChEffStats.EffDexterity = character.ChEffStats.EffDexterity * (1 + (GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CDex, ModType.Percent) / 100));

			//character.ChEffStats.EffHealth = character.ChStats.Health + GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CHth, ModType.Absolut);
			//character.ChEffStats.EffHealth = character.ChEffStats.EffHealth * (1 + (GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CHth, ModType.Percent) / 100));

			//character.ChEffStats.EffIntelligence = character.ChStats.Intelligence + GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CInt, ModType.Absolut);
			//character.ChEffStats.EffIntelligence = character.ChEffStats.EffIntelligence * (1 + (GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CInt, ModType.Percent) / 100));

			//character.ChEffStats.EffMaxLoad = (int)character.ChStats.MaxLoad + GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CML, ModType.Absolut);
			//character.ChEffStats.EffMaxLoad = character.ChEffStats.EffMaxLoad * (1 + (GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CML, ModType.Percent) / 100));

			//character.ChEffStats.EffRegeneration = character.ChStats.Regeneration + GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CReg, ModType.Absolut);
			//character.ChEffStats.EffRegeneration = character.ChEffStats.EffRegeneration * (1 + (GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CReg, ModType.Percent) / 100));

			//character.ChEffStats.EffResistance = character.ChStats.Resistance + GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CRes, ModType.Absolut);
			//character.ChEffStats.EffResistance = character.ChEffStats.EffResistance * (1 + (GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CRes, ModType.Percent) / 100));

			//character.ChEffStats.EffStrenght = character.ChStats.Strenght + GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CStr, ModType.Absolut);
			//character.ChEffStats.EffStrenght = character.ChEffStats.EffStrenght * (1 + (GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CStr, ModType.Percent) / 100));

			//character.ChEffStats.EffZombieAttraction = character.ChStats.ZombieAttraction + GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CZA, ModType.Absolut);
			//character.ChEffStats.EffZombieAttraction = character.ChEffStats.EffZombieAttraction * (1 + (GetModsValueByModAttributeType(character.AllMods, ModAttributeType.CZA, ModType.Percent) / 100));

			//foreach (int weaponTypeValue in Enum.GetValues(typeof(WeaponType))) {
			//    //character.FkChEffAccuracyCharacter1..
			//}

		}

		public List<SkillMod> GetModsByModAttributeType(List<SkillMod> modList, ModAttributeType modAttType) {
			return modList.Where(m => m.ModAttributeTypeValue == (int)modAttType).ToList<SkillMod>();
		}

		public int GetModsValueByModAttributeType(List<SkillMod> modList, ModAttributeType modAttType, ModType modType) {
			int? test = (from m in modList where m.ModAttributeTypeValue == (int)modAttType && m.ModTypeValue == (int)modType select m.Modifier).Sum();
			if (test == null)
				return 0;
			return (int)test;
		}
		#endregion

		#region User
		public User CreateOrUpdateUser(string username, string password, string email) {
			User user = GetUser(username);
			if (user == null)
				user = new User();
			user.Email = email;
			user.Passwrd = password;
			user.Username = username;
			user.ValidSince = DateTime.Now;
			user.ValidTo = DateTime.MaxValue;
			using (ISession session = sFactory.OpenSession()) {
				session.SaveOrUpdate(user);
				session.Flush();
			}
			return user;
		}



		public User GetUser(string username) {

			using (ISession session = sFactory.OpenSession()) {
				IList<User> users = session.QueryOver<User>().Where(u => u.Username == username).List<User>();
				if (users.Count > 0)
					return users[0];
				return null;
			}
		}
		#endregion
	}
}
