using UnityEngine;
using UnityEngine.UI;
using System.Collections;
struct WeaponData
{
    public int ID;
    public int IsPrime;
    public string Weapon_Name;
    public string Des;
    public int damage;
    public int price;
    public Sprite image;
    public bool owned;
};
public class Weapons : MonoBehaviour {
    WeaponData WeaponInfo;

    /*
     武器购买
    */
    public void BuyWeapon(int id ,int weatype)
    {
        switch(weatype)
        {
            case 0:
                {
                    PlayerPrefs.SetInt("Primary", id);
                    break;
                }
            case 1:
                {
                    PlayerPrefs.SetInt("Secondary", id);
                    break;
                }
        }
    }
    // Use this for initialization
    void Start () {
        // WeaponInfo.
       
    
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
