package at.dinin.zh_frontend;

import org.json.JSONException;
import org.json.JSONObject;

public class test1 {
	public int test1ID = 10;
	public test2 data;
	
	public JSONObject GetJSONObject(){
		JSONObject jo = new JSONObject();
		try {
			jo.put("test1ID", test1ID);
			jo.put("data", data.GetJSONObject());
		} catch (JSONException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return jo;
	}
}
