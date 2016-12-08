using UnityEngine;
using System.Collections;

public class Obstacles : MonoBehaviour {

	private Rigidbody2D rigi;
	public Vector2 velocity = new Vector2(-4f, 0f);

	void Start() {
		rigi = GetComponent<Rigidbody2D> ();
		rigi.velocity = velocity;
	}
}
