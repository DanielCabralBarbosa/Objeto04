using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeGravity : MonoBehaviour
{

    public int minMass = 0;
    public int maxMass = 1;
    public int minSpeed = 1;
    public int maxSpeed = 2;
    int speed;
    int force = 1;
  

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().mass = Random.Range(minMass, maxMass);
        this.speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
