using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelthaTime : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Update()
    {
        transform.position += Vector3.forward * (speed * Time.deltaTime);
    }
}