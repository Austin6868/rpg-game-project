using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquippedGuns : MonoBehaviour , Equipped
{

    public Sprite Gun1;
    public Sprite Gun2;
    public Sprite Gun3;
    public Sprite Gun4;
    public Sprite Gun5;


    public Sprite[] spriteList = new Sprite[5];//a list of guns 

    
    void Start()
    {
        //populate the list of guns
        spriteList[0] = Gun1;
        spriteList[1] = Gun2;
        spriteList[2] = Gun3;
        spriteList[3] = Gun4;
        spriteList[4] = Gun5;
    }

    void LateUpdate()
    {
        Equip();//modifies the index of the guns for it to be equipped in the equipped slot
    }
    public void Equip()
    {
        for (int i = 0; i < 5; i++)
        {
            if (Equipment.E.EG == i)
            {
                gameObject.GetComponent<Image>().sprite = spriteList[i];
            }
        }
    }
}
