using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpFollow : MonoBehaviour 
{
	public Transform target; // Pink.
	public Transform follower; // White.
	public float speed = 5f;

	void Update ()
	{
		float t = speed * Time.deltaTime;
		follower.position = Vector3.Lerp (follower.position, target.position, t);	
	}
}
	