using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public int score = 0;
	public int maxHealth = 100;
	private int currentHealth;
	public Enemy enemy;
	public Text scoreText;
    //the CurrentHealth property makes sure that the hitpoints of the Player does not go below 0
	public int CurrentHealth
	{
		get
		{
			
			return currentHealth;
		}
		set
		{
			currentHealth = value;
			if (currentHealth <= 0)
			{
				currentHealth = 0;
				
			}
		}
	}
	private HealthBar healthBar;

	
	void Start()
	{
		InvokeRepeating("GenerateEnemy", 2f , 2f);//The enemy is generated every 2 seconds
		CurrentHealth = maxHealth;
		healthBar = FindObjectOfType<HealthBar>();//modify the sprites in HealthBar for it to look like it's taking damage
		healthBar.SetMaxHealth(maxHealth);

	}

	
	void Update()
	{
		if (currentHealth <= 0)//the player dies after running out of hitpoints
		{
			GameObject.FindWithTag("Player").SetActive(false);
			GameObject.FindWithTag("Gun").SetActive(false);
		}
		scoreText = GameObject.Find("Text").GetComponent<Text>();
		if (score >= 20)
		{
			scoreText.text = "you won";
		}
		else
		{
			scoreText.text = "Score : " + score;//the text of the score is displayed in the text in the hierarichy
		}
	}

	public void TakeDamage(int damage)//the mothod that modifies player's health
	{
		CurrentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	public void GenerateEnemy()//the method that handles the instantiation of the enemy
	{
		Enemy enemyCopy = Instantiate<Enemy>(enemy);

	}
}