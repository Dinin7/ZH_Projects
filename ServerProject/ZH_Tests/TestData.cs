using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zh_BL;
using ZH_Classes;

namespace ZH_Tests {
	public class TestData {
		private DataManager _dm;

		//ctor
		public TestData() {
			_dm = new DataManager();
		}

        public User CreateTestUser()
        {
			User user = _dm.GetUser("Dinin");
			return _dm.CreateOrUpdateUser("Test_Dinin1", "test1", "dinin@gmx.com");
		}

        //public Character CreateTestCharacterLevel1() {
        //    Test22 user = _dm.GetUser("Test_Dinin1");
			
        //    //if (user == null)
        //    //    user = CreateTestUser();

        //    //Character character = _dm.CreateNewCharacter(user, "Test_Char1First", "Test_Char1Last");



        //    return character;
        //}

		
	}
}
