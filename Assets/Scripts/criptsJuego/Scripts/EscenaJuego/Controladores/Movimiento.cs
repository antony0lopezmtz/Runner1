using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour
{
	public Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3(0, 10, 0);
	}

}