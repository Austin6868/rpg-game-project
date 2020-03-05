using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquippedArmours : MonoBehaviour , Equipped
{
    
    private Sprite img1;
    public GameObject MyImage;

    // Start is called before the first frame update
    void Start()
    {
        MyImage.AddComponent(typeof(Image));
    }

    // Update is called once per frame
    void Update()
    {
        Equip();
    }
    public void Equip()
	{
        
        img1 = Resources.Load<Sprite>("/Images/Armour1");
        MyImage.GetComponent<Image>().sprite = img1;
        Debug.Log("Test script started");

    }
}
