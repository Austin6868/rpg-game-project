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

	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("GenerateEnemy", 2f , 2f);
		CurrentHealth = maxHealth;
		healthBar = FindObjectOfType<HealthBar>();
		healthBar.SetMaxHealth(maxHealth);

	}

	// Update is called once per frame
	void Update()
	{
		if (currentHealth <= 0)
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
			scoreText.text = "Score : " + score;
		}
	}

	public void TakeDamage(int damage)
	{
		CurrentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	public void GenerateEnemy()
	{
		Enemy enemyCopy = Instantiate<Enemy>(enemy);

	}
}