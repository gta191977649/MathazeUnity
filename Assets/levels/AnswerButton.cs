using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour {

	public Text uiText;
	public float numScale;

	void Start () {
		//HaveWrongtAnswer();
	}
	


	public void Answer()
	{
		GameManager.gm.ReviceAnswer(int.Parse(uiText.text));
	}


	public void HaveRightAnswer(int RightAnswer)
	{
		uiText.text= RightAnswer + "";
	}

	public void HaveWrongtAnswer()
	{
		uiText.text= (int)(Random.value * numScale) + "";
	}
}
