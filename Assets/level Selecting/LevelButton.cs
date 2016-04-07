using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class LevelButton : MyButton {


	public GameObject clearLogo;
	public GameObject lockLogo;
	public Text levelText;

	public Text nameText;
	public Image myImage;
	public Button myButton;

	public string lvlName;
	public bool isClear;
	public bool isUnLock;


	void Start () 
	{
		//PlayerPrefs.SetInt("level (0)", 1);
		switch(PlayerPrefs.GetInt(transform.name))
		{
			case 0:
				break;

			case 1:
				isUnLock=true;
				//UnlockThisLevel();
				break;

			case 2:
				isClear=true;
				//ClearThisLevel();
				break;
		}

		if(isClear)ClearThisLevel();
		if(isUnLock)UnlockThisLevel();
	}
	
	void UnlockThisLevel()
	{
		isUnLock=true;
		lockLogo.SetActive(false);
		myImage.color=Color.green;
		myButton.interactable = true;
		nameText.text=lvlName;
		nameText.gameObject.SetActive(true);
		levelText.gameObject.SetActive(true);
		string a=transform.name;
		levelText.text="Level "+a[7];
	}

	void ClearThisLevel()
	{
		UnlockThisLevel();
		isClear=true;
		clearLogo.SetActive(true);

	}
		



}
