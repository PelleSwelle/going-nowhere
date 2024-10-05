using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateGround : MonoBehaviour 
{
	public GameObject road;
	public BoxCollider roadTrigger;
	private Vector3 roadMove = new Vector3 (0f, 0f, 0.02f);
	private Vector3 SpawnTrigger = new Vector3 (0f, 0f, -10f);
	public Transform spawnPos;
	public bool hasMovedOneRoad = false;
	void Start () 
	{

	}
	
	void Update () 
	{
		road.transform.Translate(roadMove);

		if (roadMove == SpawnTrigger) 
		{
			hasMovedOneRoad = true;
		}

		//Spawn new road
		if (hasMovedOneRoad == true)
		{
			Instantiate(road, spawnPos);
			hasMovedOneRoad = false;
		}
	}
}
