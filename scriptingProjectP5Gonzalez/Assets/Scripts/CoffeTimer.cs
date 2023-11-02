using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class SStatements : MonoBehaviour
{ 
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        coffeeTemperature -= Time.deltaTime * 5f;

    }
    void TemperatureTest()
    {
        //if   the coffe's temperature is greaterr than the  hottes drrinking temperaturre...
        if (coffeeTemperature > hotLimitTemperature)
        {
            //... do this 
            print("Coffee is too hot.");
        }
        //  If it  isn't,but the coffe temperature iss less than   coldestdrinking temerature...
        else if(coffeeTemperature < coldLimitTemperature)
        {
                //...do this.
                print("Coffee its too cold.");
        }

           // If it is neither of those then...
           else
           { 
               // ...  do  this
               print("Coffee is  just right.");
           }     
    }
}