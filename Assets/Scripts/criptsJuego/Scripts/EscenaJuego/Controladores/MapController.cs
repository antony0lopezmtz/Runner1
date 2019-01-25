using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : ControladorBasico{
	public GameObject elementoInicial;
	public Transform puntoInicial;
	public GameObject elementoSiguiente;
	public Transform puntoSiguiente;

	// Use this for initialization
	void Start () {
		base.Start();
		var plataformaInicio = Instantiate(elementoInicial, puntoInicial.position, puntoInicial.rotation);
		var destino = plataformaInicio.gameObject.transform.Find("puntoFinal");
		Instantiate(elementoSiguiente, destino.position, destino.rotation);

	}

	// Update is called once per frame

	void Update () {
		
	}
	public override void juegoEnPausa()
	{
		throw new System.NotImplementedException();
	}
	public override void juegoRestaurado()
	{
		throw new System.NotImplementedException();
	}

}
