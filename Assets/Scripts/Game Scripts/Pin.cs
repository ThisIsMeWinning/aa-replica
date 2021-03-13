using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

	public int numOfLives = 5;

	private bool isPinned = false;

	public static float speed = 175f;
	public Rigidbody2D rb;

	void Update ()
	{
		if (!isPinned)
			rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);

		
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Rotator")
		{
			transform.SetParent(col.transform);
			FindObjectOfType<AudioManager>().Play("Hit");
			Score.PinCount++;
			isPinned = true;
		}

		else if (col.tag == "Pin")
		{
			FindObjectOfType<GameManager>().EndGame();
			
		}
	}
}
