

using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour 
{
	//
	// VARIABLES
	//

	public float turnSpeed = 4.0f;		
	public float panSpeed = 4.0f;	
	public float zoomSpeed = 4.0f;		

	private Vector3 origin;	// Position of cursor at beginning
	private bool isPanning;		
	private bool isRotating;	
	private bool isZooming;		


	void Update () 
	{
		// Get the left mouse button
		if(Input.GetMouseButtonDown(0))
		{
			// Get  origin
			origin = Input.mousePosition;
			isRotating = true;
		}

		// Get the right mouse button
		if(Input.GetMouseButtonDown(1))
		{
			// Get  origin
			origin = Input.mousePosition;
			isPanning = true;
		}

		// Get the middle mouse button
		if(Input.GetMouseButtonDown(2))
		{
			// Get origin
			origin = Input.mousePosition;
			isZooming = true;
		}
			
		if (!Input.GetMouseButton(0)) isRotating=false;
		if (!Input.GetMouseButton(1)) isPanning=false;
		if (!Input.GetMouseButton(2)) isZooming=false;

		// Rotate camera  X & Y 
		if (isRotating)
		{
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - origin);

			transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
			transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
		}

		// Move the camera on XY plane
		if (isPanning)
		{
			Vector3 position = Camera.main.ScreenToViewportPoint(Input.mousePosition - origin);

			Vector3 move = new Vector3(position.x * panSpeed, position.y * panSpeed, 0);
			transform.Translate(move, Space.Self);
		}

		// Move the camera on Z
		if (isZooming)
		{
			Vector3 position = Camera.main.ScreenToViewportPoint(Input.mousePosition - origin);

			Vector3 move = position.y * zoomSpeed * transform.forward; 
			transform.Translate(move, Space.World);
		}
	}
}