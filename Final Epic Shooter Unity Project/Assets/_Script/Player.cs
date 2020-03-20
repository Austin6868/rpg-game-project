using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

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