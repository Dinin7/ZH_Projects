package at.dinin.zh_frontend;

import org.json.JSONException;
import org.json.JSONObject;

public class test2 {
	public int test2ID = 50;
	
	
	public JSONObject GetJSONObject(){
		JSONObject jo = new JSONObject();
		try {
			jo.put("test2ID", test2ID);
		} catch (JSONException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return jo; //  testgvggggggghhhhhhh11111
	}
}
