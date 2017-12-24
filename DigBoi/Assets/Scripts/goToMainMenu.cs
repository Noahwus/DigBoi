using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToMainMenu : MonoBehaviour {

	public void goToMainMenuScreen(){
		SceneManager.LoadScene ("MainMenu");
		Debug.Log ("going to MainMenu");
	}
}
