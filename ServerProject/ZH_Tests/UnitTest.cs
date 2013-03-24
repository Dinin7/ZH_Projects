using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zh_BL;
using ZH_Classes;
using NHibernate.Tool.hbm2ddl;

namespace ZH_Tests {
    /// <summary>
    /// Zusammenfassungsbeschreibung für UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest {
        public UnitTest() {
            //
            // TODO: Konstruktorlogik hier hinzufügen
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Ruft den Textkontext mit Informationen über
        ///den aktuellen Testlauf sowie Funktionalität für diesen auf oder legt diese fest.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region Zusätzliche Testattribute
        //
        // Sie können beim Schreiben der Tests folgende zusätzliche Attribute verwenden:
        //
        // Verwenden Sie ClassInitialize, um vor Ausführung des ersten Tests in der Klasse Code auszuführen.
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Verwenden Sie ClassCleanup, um nach Ausführung aller Tests in einer Klasse Code auszuführen.
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Mit TestInitialize können Sie vor jedem einzelnen Test Code ausführen. 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Mit TestCleanup können Sie nach jedem einzelnen Test Code ausführen.
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TM_CreateUser() {
			// For Testing if ObjectModel deploy has errors (comment <mapping assembly="ZH_Classes" />)
			//var cfg = new NHibernate.Cfg.Configuration();
			//cfg.Configure();
			//cfg.AddAssembly(typeof(Accuracy).Assembly);
			//new SchemaExport(cfg).SetOutputFile("c:\\temp\\MyDDL.sql").Execute(true /*script*/, true /*export to db*/,	 false /*just drop*/);

            DataManager dataManager = new DataManager();
			User user = dataManager.GetUser("Dinin22");
			User newUser = dataManager.CreateOrUpdateUser("Dinin", "myPW", "dinin@gmx.com");
            Assert.AreNotEqual(0, newUser.Id);
        }

		[TestMethod]
		public void TM_CreateCharacter() {
			DataManager dataManager = new DataManager();
			User user = dataManager.CreateOrUpdateUser("Dinin", "kasim7", "dinin@gmx.com");
            //IList<Character> characters = dataManager.GetCharacters();
            //Character newChar = dataManager.CreateNewCharacter(user, string.Format("fchar_{0}",characters.Count) , string.Format("lchar_{0}", characters.Count));
            //Assert.AreNotEqual(0, newChar.Id);
			//Assert.AreEqual(newChar.ColFkChAccuracyCharacter1.Count, Enum.GetValues(typeof(WeaponType)).Length);
			
		}
    }
}
