using System;
using System.Text;
using System.Collections.Generic;
using Alchemy.Classes;


namespace ZH_Classes {
    
    public partial class User : ZHBase{
        public User() {
			Characters = new List<ZHCharacter>();
        }

		// persistent attributes
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Passwrd { get; set; }
        public virtual string Email { get; set; }
        public virtual System.DateTime LastLogin { get; set; }
        public virtual System.DateTime ValidSince { get; set; }
        public virtual System.DateTime ValidTo { get; set; }
		public virtual IList<ZHCharacter> Characters { get; set; }
    }
}
