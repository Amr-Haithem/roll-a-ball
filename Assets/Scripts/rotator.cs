using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this will rotate the current object by the provided vector
        //see docs for more documentations and amazing things
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        

    }
}
