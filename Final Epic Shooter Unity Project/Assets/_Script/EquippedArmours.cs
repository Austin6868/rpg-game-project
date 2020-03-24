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

    public Sprite [] spriteList = new Sprite [5]  ;//make a list of sprites for the armour

    
    void Start()
    {//populate the list
        spriteList[0] = Armour1;
        spriteList[1] = Armour2;
        spriteList[2] = Armour3;
        spriteList[3] = Armour4;
        spriteList[4] = Armour5;
    }

    
    void LateUpdate()
    {
        Equip();
        
    }
    public void Equip()//modifyes the sprite to the appropriated one in the equipped slot(bigger one on the top left)
	{
        for (int i = 5; i < 10; i++)
        {
            if (Equipment.E.EA == i)
            {
                gameObject.GetComponent<Image>().sprite = spriteList[i - 5];
            }
        }
    }
}
