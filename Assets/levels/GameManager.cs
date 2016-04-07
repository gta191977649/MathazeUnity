using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public class GameManager : MonoBehaviour 
{

	public static GameManager gm;

	public RamdomTest rtX;
	public RamdomTest rtY;
	public Timer t;
	public Transform answerList;
	private AnswerButton[] abList;

	public int rightAnswer;
	public Character player;
	public Character monster;

	public Text monsterCountText;
	public int monsterLeft;

	public GameObject winPanel;
	public GameObject lostPanel;
	public BlurOptimized myBlur;

	public PlayerBar playerBar;



	// Use this for initialization
	void Start () 
	{
		gm=this;
		abList = new AnswerButton[4];
		monsterCountText.text= monsterLeft+"/"+monsterLeft;
		for(int i=0; i<abList.Length; i++)
		{
			abList[i]= answerList.GetChild(i).GetComponent<AnswerButton>();
		}
		GenerateNewTest();

		//set up the player
		player.SetUp(PlayerPrefs.GetInt("hp"),PlayerPrefs.GetInt("damage"));
		monster.SetUp(10,3);
	}
	

	public void ReviceAnswer(int answer)
	{
		if(answer == rightAnswer)
		{
			player.Attack();
		}else{
			monster.Attack();
		}
		GenerateNewTest();
	}

	private void GenerateNewTest()
	{
		rtX.MakeRamdomNum();
		rtY.MakeRamdomNum();
		t.ResetTimer();

		for(int i=0; i<abList.Length; i++)
		{
			abList[i].HaveWrongtAnswer();
		}
		rightAnswer = rtX.num+rtY.num;

		abList[(int)(Random.value * 4)].HaveRightAnswer(rightAnswer);


	}

	public void UnlockAlevel(string lvlName)
	{
		PlayerPrefs.SetInt(lvlName, 1);
	}

	public void ClearAlevel(string lvlName)
	{
		PlayerPrefs.SetInt(lvlName, 2);
	}


	public void KillMonster(Character monster)
	{
		monsterLeft --;
		if(monsterLeft > 0)
		{
			playerBar.GainXp(3);
			monster.SetUp(10,3);
		}else
		{
			Win();
		}
		monsterCountText.text = monsterLeft+""+monsterCountText.text.Substring(1);

	}

	public void Killcharacter(string CharacterName)
	{
		
	}

	public void Win()
	{
		winPanel.SetActive(true);
		myBlur.enabled=true;
	}

	public void Lost()
	{
		lostPanel.SetActive(true);
		myBlur.enabled=true;
	}



}
