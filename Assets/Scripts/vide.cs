using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vide : MonoBehaviour
{
    MovieTexture myMovie;


    void Start()
    {
        myMovie.Play();
    }


    void OnGUI()
    {
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), myMovie);
    }
}
