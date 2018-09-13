using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

	public GameObject moveObject;
	public Transform targertPosition;
	public float Speed;

	void Start () {

	}
	
	void Update () {
		if (Input.GetKey(KeyCode.Space)){
			if(Vector3.Distance(moveObject.transform.position, targertPosition.position) < 0.5f)
			{
				Destroy(moveObject, 2);
			} else {
				moveObject.transform.position = Vector3.MoveTowards(
					moveObject.transform.position, targertPosition.position, Time.deltaTime*Speed);
					// moveObject.transform.LookAt(targertPosition);
			}
		}
	}
}
