using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	private int currentHealth;

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

		currentHealth = maxHealth;
		healthBar = FindObjectOfType<HealthBar>();
		healthBar.SetMaxHealth(maxHealth);
        
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}



	}