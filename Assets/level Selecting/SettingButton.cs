using UnityEngine;
using System.Collections;

public class SettingButton : MonoBehaviour 
{



	public Transform canvas;
	public bool haveAsSettingPanel = false;
	public GameObject settingPanel;

	public void OnOpenSetting()
	{
		if(!haveAsSettingPanel)
		{
			settingPanel.SetActive(true);
			haveAsSettingPanel=true;
		}
		//a.transform.SetParent(canvas);
	}

	public void OnExitSetting()
	{
		settingPanel.SetActive(false);
		haveAsSettingPanel=false;
	}
}
