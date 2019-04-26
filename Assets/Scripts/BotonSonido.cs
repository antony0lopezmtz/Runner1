using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonSonido : MonoBehaviour {

	public AudioClip beep;
	public AudioSource beepSource;
	public Button btn1;
	public Button btn2;
	public Button btn3;
	public Button btn4;
	public Button btn5;

	// Use this for initialization
	void Start () {

		beepSource.clip = beep;

	}
	
	// Update is called once per frame
	void Update () {

		btn1.onClick.AddListener(PlaySound);
		btn2.onClick.AddListener(PlaySound);
		btn3.onClick.AddListener(PlaySound);
		btn4.onClick.AddListener(PlaySound);
		btn5.onClick.AddListener(PlaySound);

	}

	void PlaySound()
	{
		beepSource.Play();
	}
	
}
