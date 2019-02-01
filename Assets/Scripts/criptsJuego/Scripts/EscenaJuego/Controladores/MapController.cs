using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : ControladorBasico {
	public GameObject elementoInicial;
	public Transform puntoInicial;
	public GameObject elementoSiguiente;
	public Transform puntoSiguiente;
	public int sizeOflist;

	public List<GameObject> mapa = new List<GameObject>();


	// Use this for initialization

	void Start() {

		base.Start();

		sizeOflist = mapa.Count;

		var plataformaInicio = Instantiate(elementoInicial, puntoInicial.position, puntoInicial.rotation);
		var destino = plataformaInicio.gameObject.transform.Find("puntoFinal");
		Instantiate(elementoSiguiente, destino.position, destino.rotation);

		Debug.Log(Random.Range(0, sizeOflist));

	}

	// Update is called once per frame

	void Update() {



	}
	public override void juegoEnPausa()
	{

	}

	public override void juegoRestaurado()
	{

	}


}
