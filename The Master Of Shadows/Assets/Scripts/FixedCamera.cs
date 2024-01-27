using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamera : MonoBehaviour
{
	public Transform Target;
	public float CameraSpeed;
	public float minX, minY;
	public float maxX, maxY;




	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	private void FixedUpdate()
	{


		if (Target != null)
		{
			Vector2 NewCamPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * CameraSpeed);
			float ClampX = Mathf.Clamp(NewCamPosition.x, minX, maxX);
			float ClampY = Mathf.Clamp(NewCamPosition.y, minY, maxY);
			transform.position = new Vector3(ClampX, ClampY, -10f);
		}


	}
}
