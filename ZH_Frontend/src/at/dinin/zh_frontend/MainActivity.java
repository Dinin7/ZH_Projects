package at.dinin.zh_frontend;

import org.json.JSONException;
import org.json.JSONObject;
import org.json.JSONStringer;

import de.tavendo.autobahn.WebSocketConnection;
import de.tavendo.autobahn.WebSocketException;
import de.tavendo.autobahn.WebSocketHandler;
import android.os.Bundle;
import android.app.Activity;
import android.util.Log;
import android.view.Menu;
import android.widget.TextView;
import at.dinin.zh_bl.WSCommunication;
import at.dinin.zh_classes.User;
import at.dinin.zh_classes.WSCommInfo;
import at.dinin.zh_classes.ZHBase;

public class MainActivity extends BaseActivity {
	//private WSCommunication wsc = WSCommunication.GetInstance();
	TextView tvInfo;
	
	private final WebSocketConnection mConnection = new WebSocketConnection();
	private final String wsuri = "ws://10.0.0.3:54321";
	private static final String TAG = "at.dinin.zh.test1";

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		tvInfo = (TextView)findViewById(R.id.tvInfo);
		tvInfo.setText("Login...");
		wsc.Connect();
		
		int counter = 0;
		do {
			try {
				counter++;
				Thread.sleep(1000);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		} while (!wsc.IsConnected() && counter < 50);
		if (!wsc.IsConnected()){
			tvInfo.setText("Connection error !");
		}
		
		//dm.LoginUser(WSCommunication.Username, WSCommunication.Password);
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.activity_main, menu);

		return true;
	}
	
	public void RetrieveMessage(WSCommInfo wsci, ZHBase object){
		switch (wsci.WSCommInfo_ActionType) {
		case WSCommInfo.WSACTION_LOGINCOMPLETE:
			if (wsci.WSCommInfo_ErrorType == WSCommInfo.WSACTION_ERROR_NONE){
				tvInfo.setText("Login successfull!");
			} else {
				tvInfo.setText("Login error !");
			}
			break;

		default:
			break;
		}
	}

}
