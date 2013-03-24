package at.dinin.zh_classes;

import org.json.JSONException;
import org.json.JSONObject;

public class WSCommInfo {
	public String WSCommInfo_ClassType;
	public int WSCommInfo_ActionType;
	public int WSCommInfo_ErrorType = 0;
	
	public ZHBase WSCommInfo_Object;
	
	public static final int WSACTION_LOGIN = 1;
	public static final int WSACTION_LOGINCOMPLETE = 2;
	
	public static final int WSACTION_ERROR_NONE = 0;
	public static final int WSACTION_ERROR_LOGINERROR = 1;
	
	public JSONObject GetJSONObject(){
		JSONObject jo = new JSONObject();
		try {
			jo.put("WSCommInfo_ClassType", WSCommInfo_ClassType);
			jo.put("WSCommInfo_ActionType", WSCommInfo_ActionType);
			jo.put("WSCommInfo_ErrorType", WSCommInfo_ErrorType);
			jo.put("WSCommInfo_Object", WSCommInfo_Object.GetJSONObject());
		} catch (JSONException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return jo;
	}
}
