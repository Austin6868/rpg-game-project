using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
    // Start is called before the first frame update
    void Start()
    {
        
=======
    static public Player E;
    public int EA = 0;
    public int EG = 5;
    
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
>>>>>>> austinBranch
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======

        if (EA >= 5 && EA >= 0)
        {
            EA = 0;
        }
        if (EG <= 4 && EG > 9)
		{
            EG = 5;
		}
>>>>>>> austinBranch
    }
}
