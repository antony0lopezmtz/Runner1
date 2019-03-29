using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyConfig : MonoBehaviour
{
	public Button botonSalto;
	public Button botonAgachado;
	public Button botonDerecha;
	public Button botonIzquierda;
	public Button botonDab;
	public Canvas panel;
	private Boolean esperarATeclaDeSalto = false;
	private Boolean esperarATeclaDeAgachado = false;
	private Boolean esperarATeclaDerecha = false;
	private Boolean esperarATeclaIzquierda = false;
	private Boolean esperarATeclaDeDab = false;

	// Use this for initialization
	void Start()
	{
		botonSalto.onClick.AddListener(jumpRebind);
		botonAgachado.onClick.AddListener(crouchRebind);
		botonDerecha.onClick.AddListener(rightRebind);
		botonIzquierda.onClick.AddListener(leftRebind);
		botonDab.onClick.AddListener(dabRebind);
		panel.enabled = false;
	}

	// Update is called once per frame
	void Update()
	{
		botonSalto.GetComponentInChildren<Text>().text = ValorOpciones.JUMP_BUTTON.ToString();
		botonAgachado.GetComponentInChildren<Text>().text = ValorOpciones.CROUCH_BUTTON.ToString();
		botonDerecha.GetComponentInChildren<Text>().text = ValorOpciones.RIGHT_BUTTON.ToString();
		botonIzquierda.GetComponentInChildren<Text>().text = ValorOpciones.LEFT_BUTTON.ToString();
		botonDab.GetComponentInChildren<Text>().text = ValorOpciones.DAB_BUTTON.ToString();
	}

	void jumpRebind()
	{
		panel.enabled = true;
		esperarATeclaDeSalto = true;
	}

	void dabRebind()
	{
		panel.enabled = true;
		esperarATeclaDeDab = true;
	}

	void leftRebind()
	{
		panel.enabled = true;
		esperarATeclaIzquierda = true;
	}

	void rightRebind()
	{
		panel.enabled = true;
		esperarATeclaDerecha = true;
	}

	void crouchRebind()
	{
		panel.enabled = true;
		esperarATeclaDeAgachado = true;
	}

	private void OnGUI()
	{
		var evento = Event.current;
		if (evento.isKey && esperarATeclaDeSalto)
		{
			Debug.Log("Pulsado: " + evento.keyCode);
			ValorOpciones.JUMP_BUTTON = evento.keyCode;
			esperarATeclaDeSalto = false;
			panel.enabled = false;
		}
		if (evento.isKey && esperarATeclaDeAgachado)
		{
			Debug.Log("Pulsado: " + evento.keyCode);
			ValorOpciones.CROUCH_BUTTON = evento.keyCode;
			esperarATeclaDeAgachado = false;
			panel.enabled = false;
		}
		if (evento.isKey && esperarATeclaDerecha)
		{
			Debug.Log("Pulsado: " + evento.keyCode);
			ValorOpciones.RIGHT_BUTTON = evento.keyCode;
			esperarATeclaDerecha = false;
			panel.enabled = false;
		}
		if (evento.isKey && esperarATeclaIzquierda)
		{
			Debug.Log("Pulsado: " + evento.keyCode);
			ValorOpciones.LEFT_BUTTON = evento.keyCode;
			esperarATeclaIzquierda = false;
			panel.enabled = false;
		}
		if (evento.isKey && esperarATeclaDeDab)
		{
			Debug.Log("Pulsado: " + evento.keyCode);
			ValorOpciones.DAB_BUTTON = evento.keyCode;
			esperarATeclaDeDab = false;
			panel.enabled = false;
		}
	}
}