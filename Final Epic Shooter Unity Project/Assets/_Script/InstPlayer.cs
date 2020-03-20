using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstPlayer : MonoBehaviour
{

    public GameObject heroOne;
    public GameObject heroTwo;

    private void Start()
    {
        int hero = PlayerPrefs.GetInt("Hero");

        if(hero == 1)
        {
            Instantiate(heroOne);
        }
        else if(hero == 2)
        {
            Instantiate(heroTwo);
        }
    }

}
