using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaCarga : MonoBehaviour {

	List<GameObject> lista;
	public int sizeOfList;

	// Use this for initialization
	void Start () {

		GameObject Random = GameObject.Find("MapController");
		MapController GeneracionPlataformas = Random.GetComponent<MapController>();
		lista = GeneracionPlataformas.mapa;
		sizeOfList = lista.Count;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter(Collider Player)
	{
		Debug.Log(Random.Range(0, sizeOfList));
	}
}
