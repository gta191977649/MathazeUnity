using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {


	private int hp;

	public int damage;

	//public Character[] monsterList;

	public Character enemy;

	public Bar hpBar;


	public void Start () 
	{
		hpBar.SetUp(hp,hp);
	}


	public void SetUp(int theHp, int theDamage)
	{
		hp = theHp;
		damage = theDamage;
		hpBar.SetUp(hp,hp);
	}

	public void Attack()
	{
		enemy.TakeHurt(damage);
	}

	public void TakeHurt(int revicedDamage)
	{
		hp -= revicedDamage;
		hpBar.ChangeValue(hp);
		CheckHp();
	}

	private void CheckHp()
	{
		if(hp <= 0)
		{
			if(this.transform.name=="monster")
			{
				GameManager.gm.KillMonster(this);
			}
			else if(this.transform.name=="player")
			{
				GameManager.gm.Lost();
			}
		}
	}



}
