using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerBar : MonoBehaviour 
{

	public Text levelText;
	public Text damageText;
	public Text moneyText;
	public Bar hpBar;
	public Bar xpBar;



	private int xp;
	// Use this for initialization
	void Start () 
	{
		//xp=PlayerPrefs.GetInt("xp");
		//PlayerPrefs.SetInt("level",2);
		Reflash();


	}
		

	// Update is called once per frame
	void Reflash () 
	{

		levelText.text = "Lv " + PlayerPrefs.GetInt("level");
		damageText.text = "damge: " + PlayerPrefs.GetInt("damage");
		//moneyText.text = "damge: " + PlayerPrefs.GetInt("damage");


		hpBar.SetUp(PlayerPrefs.GetInt("hp"),PlayerPrefs.GetInt("hp"));
		xpBar.SetUp(PlayerPrefs.GetInt("xp"),10);
	}

	public void GainXp(int gainedXp)
	{
		xp += gainedXp;
		if(xp>= 10)
		{
			PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level")+(int)(xp/10));

			PlayerPrefs.SetInt("damage", PlayerPrefs.GetInt("damage")+(int)(xp/10));
			//player.damage=PlayerPrefs.GetInt("damage");
			xp = xp%10;
		}
		xpBar.ChangeValue(xp);
		PlayerPrefs.SetInt("xp",xp);
		Reflash();
	}
}

