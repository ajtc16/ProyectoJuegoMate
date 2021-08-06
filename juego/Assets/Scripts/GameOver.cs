using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){


		if (other.tag =="Collector") {
			FindObjectOfType<AudioManager>().Play("DeadSound");
			RestarGame ();
		}
	}
	void OnCollisionEnter2D(Collision2D other){

		if (other.gameObject.tag == "Zombie") {
			FindObjectOfType<AudioManager>().Play("DeadSound");
			HealthControl.health -= 1;
			//RestarGame ();
		}


	}
	void Update(){
		if (HealthControl.endGame ==true) 
		RestarGame();
	}

	public void RestarGame(){
		ScoreScript.scoreValue = 0;
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}



}
