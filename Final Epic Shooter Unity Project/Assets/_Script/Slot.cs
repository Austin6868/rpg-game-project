using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Slot : MonoBehaviour , IPointerClickHandler

{
    public int ID;
    public string type;
    public string description;
    public bool empty;
    public Texture2D icon;


    public void OnPointerClick (PointerEventData pointerEventData)//when the mouse is clicked on the certain item it will change the sprite to the desired one
	{
        useItem();
        Debug.Log("clicked" + transform.name);
	}


    public void useItem()
	{
        
        for (int i = 0; i < 10; i++)
        {
            if (transform.name == "Slot (" + (i+1) + ")")
            {
                Equipment.E.ModifySlot(i);//move the current slot index to the selscted one
            }
        }
        
    }
}
