using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000;
	public float sidewaysForce = 500;

	// Use this for initialization
	void Start () {
		// Debug.Log ("Hello, World");
		//rb.AddForce(0, 200, 500);
	}
	
	// "Fixed"Update are using to mess with physics.
	void FixedUpdate () {
		
		// Add a forward force
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		// Add a rightside force
		if (Input.GetKey("d")) {
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// Add a leftside force
		if (Input.GetKey("a")) {
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1) {
			FindObjectOfType<GameManager> ().Gameover ();
		}

	}
}
