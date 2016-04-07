using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bar : MonoBehaviour {

	public Slider mySlider;
	public Text myText;

	private int value;
	private int maxValue = 1;



	public void SetUp(int theValue, int theMaxValue)
	{
		value = theValue;
		maxValue = theMaxValue;
		ChangeValue(value);
	}

	public void ChangeValue (int newValue) 
	{
		value = newValue;
		myText.text = value + " / " + maxValue;
		mySlider.value = (float)value / (float)maxValue;
	}





}
