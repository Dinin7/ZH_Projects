package at.dinin.zh_bl;

import org.json.JSONException;
import org.json.JSONObject;

import com.google.gson.Gson;

import android.util.Log;
import at.dinin.zh_classes.WSCommInfo;
import at.dinin.zh_classes.ZHBase;
import at.dinin.zh_classes.User;
import at.dinin.zh_frontend.BaseActivity;
import de.tavendo.autobahn.WebSocketConnection;
import de.tavendo.autobahn.WebSocketException;
import de.tavendo.autobahn.WebSocketHandler;

public class WSCommunication {
	
	private static WSCommunication WSCommunication = new WSCommunication();
	private final WebSocketConnection mConnection = new WebSocketConnection();
	private final String wsuri = "ws://10.0.0.3:54321";
	private static final String TAG = "at.dinin.zh.test1";
	public static final String Username = "Dinin";
	public static final String Password = "myPW";
	public BaseActivity CurrActivity = null;
	
	public User User = null;
	
	private WSCommunication(){
	}
	
	public static WSCommunication GetInstance(){
		return WSCommunication;
	}
	
	public Boolean IsConnected(){
		return mConnection.isConnected();
	}
	
	public void Connect(){
		try {
			if (mConnection.isConnected())
				return;
			
			mConnection.connect(wsuri, new WebSocketHandler() {

				@Override
				public void onOpen() {
					Log.d(TAG, "Status: Connected to " + wsuri);
					LoginUser(Username, Password);
				}

				@Override
				public void onTextMessage(String payload) {
					Log.d(TAG, "Got echo: " + payload);
					RetrieveMessage(payload);
				}

				@Override
				public void onClose(int code, String reason) {
					Log.d(TAG, "Connection lost.");
				}
			});
		} catch (WebSocketException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void SendMessage(int action, ZHBase object){
		if (!mConnection.isConnected())
			return; // todo: reconnect or error
		
		WSCommInfo wsci = new WSCommInfo();
		wsci.WSCommInfo_ActionType = action;
		wsci.WSCommInfo_Object = object;
		
		JSONObject jo = wsci.GetJSONObject();
//		
//		
//		try {
//			jo.put("WSCommInfo_ClassType", object.getClass().getName());
//			jo.put("WSCommInfo_ActionType", action);
//		} catch (JSONException e) {
//			// TODO Auto-generated catch block
//			e.printStackTrace();
//		}
//		
		mConnection.sendTextMessage(jo.toString());
	}
	
	public void RetrieveMessage(String json){
		Gson gson = new Gson();
		WSCommInfo wsci = gson.fromJson(json, WSCommInfo.class);
		
		ZHBase object = null;
		switch (wsci.WSCommInfo_ActionType) {
		case WSCommInfo.WSACTION_LOGINCOMPLETE:
			if (wsci.WSCommInfo_ErrorType == WSCommInfo.WSACTION_ERROR_NONE){
				User = gson.fromJson(json, User.class);
				object = User;
			} else {
				User = null;
			}
			break;

		default:
			break;
		}
		
		if (CurrActivity != null){
			CurrActivity.RetrieveMessage(wsci, object);
		}
	}
	
	public void LoginUser(String username, String password){
		User = new User();
		User.Username = username;
		User.Passwrd = password;
		SendMessage(WSCommInfo.WSACTION_LOGIN, User);
	}
	
	public void SetCurrActivity(BaseActivity baseActivity){
		CurrActivity = baseActivity;
	}

}
