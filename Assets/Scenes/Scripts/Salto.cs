﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour {
	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			animator.SetBool("saltando", true);
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			animator.SetBool("rodando", true);
		}
	}
	public void finalizarAnimacion()
	{
		animator.SetBool("saltando", false);

	}
	public void finalizarRodado()
	{
		animator.SetBool("rodando", false);

	}
}
