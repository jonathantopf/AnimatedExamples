using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinNoise : MonoBehaviour 
{
	public Transform whiteBall;
	public Transform greenBall;
	public Transform pinkBall;
	public Transform goldBall;

	void Update ()
	{
		float lowFreqency = Mathf.Sin (Time.time * 2.132f);
		float mediumFreqency = Mathf.Sin (Time.time * 3.25f);
		float highFrequency = Mathf.Sin (Time.time * 4.96f);

		whiteBall.position = new Vector3 (0, lowFreqency, 0);
		greenBall.position = new Vector3 (1.5f, mediumFreqency, 0);
		pinkBall.position = new Vector3 (3f, highFrequency, 0);

		float combined = lowFreqency + mediumFreqency + highFrequency;
		goldBall.position = new Vector3 (4.5f, combined, 0);
	}
}



