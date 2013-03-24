package at.dinin.zh_classes;

import java.util.Date;

import org.json.JSONException;
import org.json.JSONObject;

public class User extends ZHBase{
	// persistent attributes
    public int Id;
    public String Username;
    public String Passwrd ;
    public String Email;
    public Date LastLogin;
    public Date ValidSince;
    public Date ValidTo;
    
    
    public JSONObject GetJSONObject(){
    	JSONObject jo = new JSONObject();
		try {
			jo.put("Id", Id);
			jo.put("Username", Username);
			jo.put("Passwrd", Passwrd);
			jo.put("Email", Email);
			jo.put("LastLogin", LastLogin);
			jo.put("ValidSince", ValidSince);
			jo.put("ValidTo", ValidTo);
		} catch (JSONException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return jo;
//    	object.put("DataType", "SkillMod");
//    	object.put("DataType", "SkillMod");
//    	object.put("DataType", "SkillMod");
//    	object.put("DataType", "SkillMod");
//    	object.put("DataType", "SkillMod");
//    	object.put("DataType", "SkillMod");
//    	object.put("DataType", "SkillMod");
    }
}
