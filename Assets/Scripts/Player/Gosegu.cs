using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Gosegu : MonoBehaviour
{
	private int rotation = 0;
	private int rotateSpeed = 2;
	private float timer = 0f;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void LateUpdate()
	{
		timer += Time.fixedDeltaTime;
		if (timer > rotateSpeed)
		{
			rotation++;
			if (rotation == 360) rotation = 0;
			transform.rotation = Quaternion.Euler(new Vector3(0, rotation, 0));
			timer = 0f;
		}
	}
}
