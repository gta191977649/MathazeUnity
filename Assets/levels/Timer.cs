using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float timer;
	float countDown;
	public float maxTime;
	public Text uiText;
	public Slider uiSlider;

	public Character monster;

	// Use this for initialization
	void Start () 
	{
		
	}


	// Update is called once per frame
	void Update () 
	{
	
		timer += Time.deltaTime;

		uiText.text = (maxTime-(int)timer) + " s";
		uiSlider.value = timer/maxTime;

		if(maxTime - timer < 0)
		{
			monster.Attack();
			ResetTimer();
		}
	}

	public void ResetTimer()
	{
		timer=0f;
	}


}
