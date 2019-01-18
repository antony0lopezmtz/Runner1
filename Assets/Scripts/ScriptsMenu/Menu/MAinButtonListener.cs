using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MAinButtonListener : MonoBehaviour {

	public Button btnPlay, btnOptions, btnExit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		btnPlay.onClick.AddListener(play);
	}
	void play()
	{
		Application.LoadLevel("Play");
	}
}
