using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationsAndSintax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // This lane is there to tell me the X position of my object 

        /* hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);

        

        if (transform.position.y <= 5f)
        {
            Debug.Log("i'm about to hit the ground");
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
