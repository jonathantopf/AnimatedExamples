using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpFollowChain : MonoBehaviour 
{
	public Transform target; // Pink.
	public Transform follower1; // White.
	public Transform follower2; // Green.
	public Transform follower3; // Green.
	public float speed = 7f;

	void Update ()
	{
		float t = speed * Time.deltaTime;
		Vector3 follower2Target = follower1.position + Vector3.up * 0.5f;
		Vector3 follower3Target = follower2.position + Vector3.up * 0.5f;
		follower1.position = Vector3.Lerp (follower1.position, target.position, t);	
		follower2.position = Vector3.Lerp (follower2.position, follower2Target, t);	
		follower3.position = Vector3.Lerp (follower3.position, follower3Target, t);	
	}
}
	