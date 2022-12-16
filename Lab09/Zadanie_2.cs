using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Zadanie_2 : MonoBehaviour 
{
	private AIPath aiPath;
	private GameObject enemies;
	void Start()
	{
        enemies = GameObject.FindGameObjectWithTag("Enemies");
		aiPath = enemies.GetComponent<AIPath>();
	}
	void FixedUpdate()
	{
		if(aiPath.desiredVelocity.x >= 0.01f)
		{
			transform.localScale = new Vector3(-1f, 1f, 1f);
		}else if (aiPath.desiredVelocity.x <= -0.01f)
		{
			transform.localScale = new Vector3(1f, 1f, 1f);
		}
	}
}