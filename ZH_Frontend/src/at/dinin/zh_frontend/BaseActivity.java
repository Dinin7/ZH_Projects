package at.dinin.zh_frontend;

import android.app.Activity;
import android.os.Bundle;
import at.dinin.zh_bl.WSCommunication;
import at.dinin.zh_classes.WSCommInfo;
import at.dinin.zh_classes.ZHBase;

public class BaseActivity extends Activity{
	protected WSCommunication wsc = WSCommunication.GetInstance();
	
	@Override
	protected void onResume() {
		wsc.SetCurrActivity(this);
		super.onResume();
	}
	
	public void RetrieveMessage(WSCommInfo wsci, ZHBase object){
		
	}
}
