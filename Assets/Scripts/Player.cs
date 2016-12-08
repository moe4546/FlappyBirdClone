using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody2D gravity;
	public Vector2 jumpForce = new Vector2 (0, 300f);

	void Start() {
		gravity = GetComponent<Rigidbody2D> ();
	}

	void Update() {
		if(Input.GetMouseButton(0)) {
			gravity.velocity = Vector2.zero;
			gravity.AddForce (jumpForce);
		}
	}

	void OnCollisionEnter2D() {
		Application.LoadLevel (Application.loadedLevel);
	}
}
