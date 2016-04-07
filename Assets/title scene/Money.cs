using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Money : MonoBehaviour {


	public Text  uiText;

	// Use this for initialization
	void Start () 
	{
		uiText.text = "" + GetMoney();
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void SaveMoney(int money)
	{
		PlayerPrefs.SetInt("money", money);
	}


	int GetMoney()
	{
		return PlayerPrefs.GetInt("money");
	}


	public void earnMoney(int earn)
	{
		int m = GetMoney();
		m += earn;
		SaveMoney(m);
	}


}
