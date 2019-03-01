using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : ControladorBasico
{

	public GameObject elementoInicial;

	public Transform puntoInicial;

	public GameObject elementoActual;

	public List<GameObject> mapa;
	// Use this for initialization
	void Start()
	{
		base.Start();
		mapa = new List<GameObject>();
		encontrarPlataformas();
		//                      GameObject              Position                        Rotation
		var plataformaInicio = Instantiate(elementoInicial, puntoInicial.position, puntoInicial.rotation);
		Transform destino = plataformaInicio.gameObject.transform.Find("puntoFinal");
		int numeroAleatorio = Random.Range(0, mapa.Count);
		Debug.Log(numeroAleatorio);
		var elementoAleatorio = mapa[numeroAleatorio];
		Debug.Log(elementoAleatorio);
		elementoActual = Instantiate(elementoAleatorio, destino.position, destino.rotation);
	}

	void encontrarPlataformas()
	{
		var plataforma1 = GameObject.Find("Pasillo");
		mapa.Add(plataforma1);
		var plataforma2 = GameObject.Find("saltoEntero");
		mapa.Add(plataforma2);
		var plataforma3 = GameObject.Find("saltoDerecha");
		mapa.Add(plataforma3);
		var plataforma4 = GameObject.Find("saltoIzquierda");
		mapa.Add(plataforma1);
		var plataforma5 = GameObject.Find("paredIzquierda");
		mapa.Add(plataforma2);
		var plataforma6 = GameObject.Find("paredDerecha");
		mapa.Add(plataforma3);
		var plataforma7 = GameObject.Find("agachardeDerecha");
		mapa.Add(plataforma1);
		var plataforma8 = GameObject.Find("agacharseIzquierda");
		mapa.Add(plataforma2);
		var plataforma9 = GameObject.Find("agacharseMedio");
		mapa.Add(plataforma3);
		var plataforma10 = GameObject.Find("pasilloMedio");
		mapa.Add(plataforma2);
		var plataforma11 = GameObject.Find("pasilloMedioSalto");
		mapa.Add(plataforma3);
	}

	// Update is called once per frame
	void Update()
	{

	}

	public override void juegoEnPausa()
	{

	}

	public override void juegoRestaurado()
	{

	}
}