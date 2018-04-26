using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;

	//we don't use that because it can be used only one time.
	//public GameManager gameManager; 

	void OnCollisionEnter (Collision collisionInfo) {

		//Debug.Log (collisionInfo.collider.name);

		if (collisionInfo.collider.tag == "Obstacle") {
			//Debug.Log ("We hit an obstacle!");

			movement.enabled = false;

			FindObjectOfType<GameManager> ().Gameover ();
		}
	}
}
