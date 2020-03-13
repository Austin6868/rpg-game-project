using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment 
{



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


    public float EA = 5;
    public float EG = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (E == null)
        {
            E = this;
        }
        else
        {
            Debug.LogError("Hero.Awake() - attempted to assign second Hero.S");
        }

    }
    
    // Update is called once per frame
    void Update()
    { 
        if (EG >= 5 || EG >= 0)
        {
            EG = 0;
        }
        if (EA <= 4 || EA > 9)
        {
            EA = 5;
        }
        Debug.Log(EA);

    }
    public void ModifySlot(int i)
	{
        if (i >=5 && i<10)
		{
            EA = i;
        }else if (i <5 && i >= 0)
		{
            EG = i;
		}
        

	}
}
