using UnityEngine;
using System.Collections;

public class ReSetButton : MonoBehaviour {


    void Start()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        if (!PlayerPrefs.HasKey("level")) // 判断是否
        { 
            //PlayerPrefs.DeleteAll();
            //玩家状态
            PlayerPrefs.SetInt("level", 1);
            PlayerPrefs.SetInt("hp", 10);
            PlayerPrefs.SetInt("damage", 3);

            //玩家装扮
            PlayerPrefs.SetInt("head", 0);
            PlayerPrefs.SetInt("body", 0);
            PlayerPrefs.SetInt("eys", 0);
            //玩家手持
            PlayerPrefs.SetInt("Primary", 0);
            PlayerPrefs.SetInt("Secondary", 0);
        }

    }
}
