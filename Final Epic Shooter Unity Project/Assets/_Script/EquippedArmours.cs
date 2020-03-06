using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquippedArmours : MonoBehaviour , Equipped
{

    public Sprite Armour1;
    public Sprite Armour2;
    public Sprite Armour3;
    public Sprite Armour4;
    public Sprite Armour5;

    public Sprite [] spriteList = new Sprite [5]  ;

    // Start is called before the first frame update
    void Start()
    {
        spriteList[0] = Armour1;
        spriteList[1] = Armour2;
        spriteList[2] = Armour3;
        spriteList[3] = Armour4;
        spriteList[4] = Armour5;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        for (int i = 5; i < 10; i++)
        {
            if (Player.E.EA == i)
            {
                gameObject.GetComponent<Image>().sprite = spriteList[i - 5];
            }
        }
        
    }
}
