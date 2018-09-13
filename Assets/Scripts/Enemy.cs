using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject Car;

	void Start () {
		
	}
	
	void Update () {
		if (Car != null && Vector3.Distance(Car.transform.position, transform.position) < 1.5f) {
			Destroy(Car);
			Application.LoadLevel(1);
		}
	}
}
