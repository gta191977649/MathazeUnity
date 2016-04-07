using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RamdomTest : MonoBehaviour {

	public Text uiText;
	public int num;
	public float numScale=10f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MakeRamdomNum()
	{
		num=(int)(Random.value * numScale);
		uiText.text = num + "";
	}
}
