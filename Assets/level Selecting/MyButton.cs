using UnityEngine;
using System.Collections;

public class MyButton : MonoBehaviour {


	public void OnSelectLevelButton ()
	{
		//SceneManager.LoadScene(transform.name);
		Application.LoadLevel(transform.name);
	}


}
