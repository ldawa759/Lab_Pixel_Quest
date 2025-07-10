using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    string variable1 = "Hello ";
    int var = 3;
    // Start is called before the first frame update
    void Start()
    {
        string variable2 = "World";
        Debug.Log(variable1 + variable2);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var);
        var++;
        transform.position += new Vector3(0.005f, 0, 0);
    }
}
