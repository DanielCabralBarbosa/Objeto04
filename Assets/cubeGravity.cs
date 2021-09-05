using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGravity : MonoBehaviour
{

    int minMass = 1;
    int maxMass = 100;


    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().mass = Random.Range(minMass, maxMass);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
