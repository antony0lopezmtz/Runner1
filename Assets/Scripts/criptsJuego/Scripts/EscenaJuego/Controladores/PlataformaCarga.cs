using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaCarga : MonoBehaviour {

	List<GameObject> lista;
	public 

	// Use this for initialization
	void Start () {

		GameObject Random = GameObject.Find("MapController");
		MapController GeneracionPlataformas = Random.GetComponent<MapController>();
		var sizeOfList = GeneracionPlataformas.mapa;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
