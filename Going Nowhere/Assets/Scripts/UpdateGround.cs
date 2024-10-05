using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateGround : MonoBehaviour 
{
	public GameObject road;
	public BoxCollider roadTrigger;
	private Vector3 update = new Vector3 (0f, 0f, 0.02f);
	public Transform spawnPos;
	void Start () 
	{

	}
	
	void Update () 
	{
		road.transform.Translate(update);

		//Spawn new road
		if (roadTrigger)
		{
			Instantiate(road, spawnPos);
		}
	}
}
