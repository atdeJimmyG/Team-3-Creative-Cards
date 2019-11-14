using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class cameraControl : MonoBehaviour
{
    public Camera OvergroundCamera;
    public Camera UndergroundCamera;

    public void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            UndergroundCamera.enabled = true;
            OvergroundCamera.enabled = false;
        }
        else
        {
            if (Input.GetKeyDown("space"))
            {
                UndergroundCamera.enabled = false;
                OvergroundCamera.enabled = true;
            }

        }

    }
}
