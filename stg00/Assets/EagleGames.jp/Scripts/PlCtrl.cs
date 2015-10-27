using UnityEngine;
using System.Collections;

public class PlCtrl : MonoBehaviour
{
	public float speed = 1f;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		var dir = Vector3.zero;

		if (Input.GetKey(KeyCode.UpArrow) == true)
		{
			dir.z = 1f;
		}
		else if (Input.GetKey(KeyCode.DownArrow) == true)
		{
			dir.z = -1f;
		}

		if (Input.GetKey(KeyCode.LeftArrow) == true)
		{
			dir.x = -1f;
		}
		else if (Input.GetKey(KeyCode.RightArrow) == true)
		{
			dir.x = 1f;
		}

		transform.Translate(dir.normalized * Time.deltaTime * speed);
	}
}
