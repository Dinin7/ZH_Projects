using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public partial class Merchantrelation {
		public virtual int Id { get; set; }
		public virtual int CharacterID { get; set; }
		public virtual int MerchantID { get; set; }
		public virtual int RelationPoints { get; set; }
		public virtual System.Nullable<System.DateTime> FirstTransaction { get; set; }
		public virtual System.Nullable<System.DateTime> LastTransaction { get; set; }
    }
}
