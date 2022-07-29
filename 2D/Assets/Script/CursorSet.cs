using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSet : MonoBehaviour
{
    public Texture2D cursorTexture;

    private void Start()
    {
        //Cursor.visible = false;
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.ForceSoftware);

    }
    void OnMouseEnter()
    {
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
    }
}
