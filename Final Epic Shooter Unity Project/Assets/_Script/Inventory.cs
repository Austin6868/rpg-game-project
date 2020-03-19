using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour { 
    public GameObject inventory;
    private bool inventoryEnabled;

    private int allSlots;
    private int enabledSlots;
    private GameObject []slot;

    public GameObject slotHolder;
    public GameObject canvas;



    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindWithTag("Canvas");
        slotHolder = GameObject.FindWithTag("Holder");
        inventory = GameObject.FindWithTag("Inventory");
        allSlots = 10;
        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
		{
            slot[i] = slotHolder.transform.GetChild(i).gameObject;
		}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
		{
            inventoryEnabled = !inventoryEnabled;
		}
        if (inventoryEnabled == true) {
            inventory.SetActive(true);
		}
		else
		{
            inventory.SetActive(false);
		}

    }

        
    }


