using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamageable : MonoBehaviour
{
	public int spikeDamage;

	void OnTriggerStay2D(Collider2D other)
	{
		RubyController controller = other.GetComponent<RubyController>();

		if(controller != null)
		{
			controller.ChangeHealth(spikeDamage * -1);
		}
	}
}