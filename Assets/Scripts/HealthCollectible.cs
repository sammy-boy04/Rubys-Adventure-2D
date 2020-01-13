﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
	public int healthRegen;

	void OnTriggerEnter2D(Collider2D other)
	{
		RubyController controller = other.GetComponent<RubyController>();

		if(controller != null && controller.health < controller.maxHealth)
		{
			controller.ChangeHealth(healthRegen);
			Destroy(gameObject);
		}
	}
}
