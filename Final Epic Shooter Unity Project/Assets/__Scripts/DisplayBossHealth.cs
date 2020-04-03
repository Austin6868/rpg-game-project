using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayBossHealth : MonoBehaviour
{
    public EnemyTwo boss;


    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = "THE BOSS'S HEALTH: " + boss.maxHealth.ToString();//displays the boss's health
    }
}
