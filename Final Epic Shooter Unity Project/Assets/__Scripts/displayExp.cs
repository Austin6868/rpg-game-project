using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayExp : MonoBehaviour
{


    
    void Update()
    {
        gameObject.GetComponent<Text>().text = "EXP: " + Equipment.E.exp.ToString();//displaying the exp count
    }
}
