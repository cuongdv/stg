using UnityEngine;
using System.Collections;

public class P47Animation : MonoBehaviour
{
	public Transform propeller;
	public Vector3 axis = Vector3.up;
	public float angle = 10f;


	public Transform rootNode;
	[Range(-1f, 1f)]
	public float roll = 0f;

	/// <summary>
	/// 入力がなくなった時の水平に復元しようとする速度
	/// </summary>
	public float restoreSpeed = 2f;

	public float maxDegree = 45f;
	public float input { get; set; }

	// Use this for initialization
	void Start()
	{
		input = 0;
	}

	// Update is called once per frame
	void Update()
	{
		propeller.Rotate(axis, angle);

		if (input < 0)
		{
			roll = Mathf.MoveTowardsAngle(roll, -1f, Time.deltaTime);
		}
		else if(input > 0)
		{
			roll = Mathf.MoveTowardsAngle(roll, 1f, Time.deltaTime);
		}
		else
		{
			roll = Mathf.MoveTowardsAngle(roll, 0f, restoreSpeed * Time.deltaTime);
		}

		rootNode.rotation = Quaternion.Euler(0, 0, roll * maxDegree);
	}
}
