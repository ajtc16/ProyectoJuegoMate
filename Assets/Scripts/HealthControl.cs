using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthControl : MonoBehaviour {

	public GameObject heart1, heart2, heart3;
	public static int health;
	public static bool endGame = false;
	// Use this for initialization
	void Start () {
		health = 3;
		heart1.gameObject.SetActive (true);
		heart2.gameObject.SetActive (true);
		heart3.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (health > 3) {
			health = 3;
		}

		switch (health) {
		case 3:
			heart1.gameObject.SetActive (true);
			heart2.gameObject.SetActive (true);
			heart3.gameObject.SetActive (true);
			endGame = false;
			break;
		case 2:
			heart1.gameObject.SetActive (true);
			heart2.gameObject.SetActive (true);
			heart3.gameObject.SetActive (false);
			endGame = false;
			break;
		case 1:
			heart1.gameObject.SetActive (true);
			heart2.gameObject.SetActive (false);
			heart3.gameObject.SetActive (false);
			endGame = false;
			break;
		case 0:
			heart1.gameObject.SetActive (false);
			heart2.gameObject.SetActive (false);
			heart3.gameObject.SetActive (false);
			// cuando todos los corazones se pediron se reinicia el mundo y se pone en0 el marcador
			endGame = true;
			break;
		}
	}
}
