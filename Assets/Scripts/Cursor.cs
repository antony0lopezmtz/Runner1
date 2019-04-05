﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cursor : MonoBehaviour {

	private static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
	{

	}
	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;
	void OnMouseEnter()
	{
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
	}

	void OnMouseExit()
	{
		Cursor.SetCursor(null, Vector2.zero, cursorMode);
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
