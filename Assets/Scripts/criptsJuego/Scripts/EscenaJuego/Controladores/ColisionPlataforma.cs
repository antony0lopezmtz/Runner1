
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPlataforma : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			var script_mapa = GameObject.Find("MapController").GetComponent<MapController>();
			int numeroAleatorio = Random.Range(0, script_mapa.mapa.Count);
			var elementoAleatorio = script_mapa.mapa[numeroAleatorio];
			var puntoFinal = script_mapa.elementoActual.transform.GetChild(0);
			script_mapa.elementoActual = Instantiate(elementoAleatorio, puntoFinal.position, puntoFinal.rotation);
			Debug.Log("NuevaP");
		}
		
	}
}