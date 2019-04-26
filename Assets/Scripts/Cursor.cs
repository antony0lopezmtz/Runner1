using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cursor : MonoBehaviour {

	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
	{

	}

	// Update is called once per frame
	void Update () {

		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);

	}

}
