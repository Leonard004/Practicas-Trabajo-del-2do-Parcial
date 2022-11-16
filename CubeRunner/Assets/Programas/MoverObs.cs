using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObs : MonoBehaviour
{
	public float lifeTime; 
	private Rigidbody2D rb;

	[Range(-1, -20)]
	public float velocidad = -5;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();

		Destroy(gameObject, lifeTime);  
	}

	void Update()
	{
		transform.position += new Vector3(velocidad, 0, 0) * Time.deltaTime;  
	}
}
