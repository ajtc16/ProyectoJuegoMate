using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


	public void PlayGame(){
		//SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		SceneManager.LoadScene ("Level 1");
	}

	public void QuitGame(){

		Debug.Log ("Quit!!");
		Application.Quit();
	}


	public void PlayWorldSuma(){
		SceneManager.LoadScene ("Level Suma");
	}

	public void PlayWorldResta(){
		SceneManager.LoadScene ("Level Resta");
	}

	public void PlayWorldMul(){
		SceneManager.LoadScene ("Level Mul");
	}

	public void PlayWorldDiv(){
		SceneManager.LoadScene ("Level Div");
	}

	public void PlayWorldMenu(){
		SceneManager.LoadScene ("Menu");
	}
}
