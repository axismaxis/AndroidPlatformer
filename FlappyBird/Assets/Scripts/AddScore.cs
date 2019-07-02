using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
	public PipeSpawner pipeSpawner;

	private void Start() {
		pipeSpawner = GameObject.FindGameObjectWithTag("PipeController").GetComponent<PipeSpawner>();
	}

    private void OnTriggerEnter2D(Collider2D other) 
	{
		Score.score += 1;
		if(Score.score % 3 == 2)
		{
			pipeSpawner.IncreaseSpeed();
		}
	}
}
