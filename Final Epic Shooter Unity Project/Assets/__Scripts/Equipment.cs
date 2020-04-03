using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment 
{


    //Singleton for other scripts to check the equipped equipments
    public static Equipment e;

    public static Equipment E
    {
        get
        {
            if (e == null)
            {
                e = new Equipment();
            }
            return e;
        }
        set
        {
            e = value;
        }
    }


    public float EA = 5;//the index of equipped armour
    public float EG = 0;//the index of equipped guns
    public int exp;

    // Start is called before the first frame update
    void Start()
    {
        if (E == null)//detecting if the singleton already exists
        {
            E = this;
        }
        else
        {
            Debug.LogError("Hero.Awake() - attempted to assign second Hero.S");
        }

    }
    
    void Update()
    { 
        if (EG >= 5 || EG >= 0)//makes sure the guns do not go off index
        {
            EG = 0;
        }
        if (EA <= 4 || EA > 9)//makes sure the armours do not go off index
        {
            EA = 5;
        }
        Debug.Log(EA);


    }
    public void ModifySlot(int i)//the method that reaches out for the changes of the the weapons and armours
	{
        if (i >=5 && i<10)
		{
            EA = i;
        }else if (i <5 && i >= 0)
		{
            EG = i;
		}
        

	}
    public void addXPEnemy()
    {
        exp += 20;
    }
    public void addXPEnemyTwo()
    {
        exp += 200;
    }
}
