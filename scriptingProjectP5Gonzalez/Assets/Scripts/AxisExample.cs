using UnityEngine;
<<<<<<< HEAD
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{ public float range;
public Text textOutput;
=======
using System.Collections;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float range;
    public Text textOutput;
>>>>>>> 695c606c36f7879553e125cde4bbf1c0f207bca8


    void Update()
    {
<<<<<<< HEAD
        float h = Input.GetAxis("Horrizontal");
        float xPos = h * range;

       

=======
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");
>>>>>>> 695c606c36f7879553e125cde4bbf1c0f207bca8
    }
}