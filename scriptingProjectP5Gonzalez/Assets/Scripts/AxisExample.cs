using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{ public float range;
public Text textOutput;


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horrizontal");
        float xPos = h * range;

       

    }
}
