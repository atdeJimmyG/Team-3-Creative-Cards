﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public static bool detection = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Flashlight")
        {
            detection = true;
        }
    }
}
