using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Flashlight")) {
            flashlight.SetActive(!flashlight.activeSelf);
        }
    }
}
