using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) Application.Quit();
    }
}