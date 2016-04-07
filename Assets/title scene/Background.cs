using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Background : MonoBehaviour 
{

	public Sprite[] backgroundList;

	public Image uiImage;

	public int bgNumber;

	public Transform levelSelectButton;


	void Start () 
	{
		ChangeScene();
	}
	

	void Update () 
	{
	
	}

	public void OnNextBackgroundButton()
	{
		if(bgNumber < backgroundList.Length-1){ bgNumber ++;}
		else if(bgNumber == backgroundList.Length-1) {bgNumber = 0;}
		ChangeScene();
	}

	public void OnLastBackgroundButton()
	{
		if(bgNumber > 0) {bgNumber --;}
		else if(bgNumber == 0){bgNumber = backgroundList.Length-1;}
		ChangeScene();
	}

	void ChangeScene()
	{
		uiImage.sprite=backgroundList[bgNumber];
		levelSelectButton.name = "level selecting " + bgNumber;
	}



}
