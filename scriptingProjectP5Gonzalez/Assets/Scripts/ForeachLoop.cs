using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings= new string[3];

        strings[0] = "hola";
        strings[1] = "hi";
        strings[2] = "a";

        foreach (string iteam in strings)
        {
            print(iteam);
        }
    }

}
