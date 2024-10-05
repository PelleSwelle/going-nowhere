using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiText : MonoBehaviour 
{
	public Text title;

	public Canvas UICanvas;
	private CameraControl cameraControl;

	// Use this for initialization
	void Start () 
	{
		cameraControl = GetComponent<CameraControl>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (cameraControl.toggleViewButton)
		{
			//Display "Title" on canvas
		}
	}
}
