using UnityEngine;
using System.Collections;

public class Create : MonoBehaviour {

	public GameObject rocks;

	void Start() {
		InvokeRepeating ("CreateRocks", 1f, 1.5f);
	}

	void CreateRocks() {
		Instantiate (rocks);
	}
}
