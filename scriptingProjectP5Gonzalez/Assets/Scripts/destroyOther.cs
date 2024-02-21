using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOther : MonoBehaviour
{
    public GameObject other;
    void Update()
    {
        {

            if (Input.GetKey(KeyCode.Q))
            {
                Destroy(other);
            }
        }
    }
}
