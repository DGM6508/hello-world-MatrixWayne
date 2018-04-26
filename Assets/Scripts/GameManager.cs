using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gamehasended = false;

	public float restartDelay = 3;

	public GameObject completeLevelUI;

	public void CompleteLevel (){
		//Debug.Log ("level 1");
		completeLevelUI.SetActive(true);
	}

	public void Gameover(){

		if (gamehasended == false) {

			//End the game
			gamehasended = true;
			Debug.Log ("GAME OVER!");

			//Restart the game
			//Restart();
			Invoke("Restart", restartDelay);
		}

	}

	void Restart(){
		//SceneManager.LoadScene ("Level_01");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
