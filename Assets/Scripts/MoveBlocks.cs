using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour {

	public Transform targertPosition;
	public float Speed;

	void Start () {
		Destroy(gameObject, 20);
	}
	
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, targertPosition.position, Time.deltaTime*Speed);
	}
}
