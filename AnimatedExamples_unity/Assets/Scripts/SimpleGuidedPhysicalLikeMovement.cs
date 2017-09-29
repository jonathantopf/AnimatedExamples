using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGuidedPhysicalLikeMovement : MonoBehaviour 
{
	public Transform target; // Pink ball;
	public Transform follower; // White ball;

	public float acceleration = 5f;
	public float attenuation = 0.9f;

	Vector3 _velocity;

	void Update ()
	{
		Vector3 towardTarget = target.position - follower.position;
		_velocity += acceleration * towardTarget;
		_velocity *= attenuation;
		follower.position += _velocity * Time.deltaTime;
	}

	// jonathantopf.com
}




