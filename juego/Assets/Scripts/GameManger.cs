using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameManger : MonoBehaviour {

	public Question[] preguntas;
	private static List<Question> unansweredQuestions;

	private Question currentQuestion;

	[SerializeField]
	private Text factText;

	[SerializeField]
	private float timeBetweenQuestions = 1f;

	public PlayerMovement player;

	public void Start(){

		if (unansweredQuestions == null || unansweredQuestions.Count==0) {
			unansweredQuestions = preguntas.ToList<Question> ();
		}

		SetCurrentQuestion ();
		//Debug.Log (currentQuestion.fact + " is "+ currentQuestion.isTrue);
	}



	public void SetCurrentQuestion(){

		int randomQuestionIndex = Random.Range (0, unansweredQuestions.Count);
		currentQuestion = unansweredQuestions [randomQuestionIndex];


		factText.text = currentQuestion.fact;


	}

	IEnumerator TransitionToNextQuestion(){

		unansweredQuestions.Remove(currentQuestion);

		yield return new WaitForSeconds (timeBetweenQuestions);

		SetCurrentQuestion ();

		//SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void userSelectTrue(){


		if (currentQuestion.isTrue) {
			Debug.Log ("CORRECT!!");
			//se suma un punto por cntestar correctamente
			ScoreScript.scoreValue += 1;
			// Finds the object the script "IGotBools" is attached to and assigns it to the gameobject called g.

			GameObject g = GameObject.FindGameObjectWithTag("Jugador");
			//assigns the script component "IGotBools" to the public variable of type "IGotBools" names boolBoy.
			player = g.GetComponent<PlayerMovement> ();

			// accesses the bool named "isOnFire" and changed it's value.
			player.Jump();

		} else {
			Debug.Log ("WRONG!!");
			HealthControl.health -= 1;
		}	
		StartCoroutine(TransitionToNextQuestion () );

	}

	public void userSelectFalse(){


		if (!currentQuestion.isTrue) {
			Debug.Log ("CORRECT!!");
			//se suma un punto por cntestar correctamente
			ScoreScript.scoreValue += 1;
			// Finds the object the script "IGotBools" is attached to and assigns it to the gameobject called g.

			GameObject g = GameObject.FindGameObjectWithTag("Jugador");
			//assigns the script component "IGotBools" to the public variable of type "IGotBools" names boolBoy.
			player = g.GetComponent<PlayerMovement> ();

			// accesses the bool named "isOnFire" and changed it's value.
			player.Jump();
		} else {
			Debug.Log ("WRONG!!");
			HealthControl.health -= 1;

		}	

		StartCoroutine(TransitionToNextQuestion () );
	}
}
