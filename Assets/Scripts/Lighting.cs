using UnityEngine;
using System.Collections;

public class Lighting : MonoBehaviour 
{
	private bool isMousePressed; // Used to determine whether mouse buttono is pressed or not
	void Start () 
	{
		isMousePressed = false;
	}

	void Update ()
	{
		if(Input.GetMouseButtonDown(0))
			isMousePressed = true;
		else if(Input.GetMouseButtonUp(0))
			isMousePressed = false;

		// Following lines move the light at mouse position
		if(isMousePressed)
		{
			Vector3 lightPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			lightPos.z = -1;
			transform.position = lightPos;
		}
	}
}