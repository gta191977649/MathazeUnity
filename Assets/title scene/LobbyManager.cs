using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour {

	public Text uiText;
	public Bar xpBar;
	public Bar hpBar;
	// Use this for initialization
	void Start () 
	{
		//DontDestroyOnLoad(this.transform);

		uiText.text = "Lv " + PlayerPrefs.GetInt("level");
		xpBar.SetUp(PlayerPrefs.GetInt("xp"),10);
		hpBar.SetUp(PlayerPrefs.GetInt("hp"),10);

	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
