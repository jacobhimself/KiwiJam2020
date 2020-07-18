using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is to be applied to objects with a collider attached.
//DON'T FORGET TO SET THE COLLIDER TO 'IS TRIGGER'
public class windyBoy : MonoBehaviour
{
    public playerBalance player;

    //wind < 0 = towards Left
    //wind > 0 = towards Right;
    public float windDirection = 0f;
    public float windStrength = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
    }
        private void OnTriggerEnter(Collider other)
    {
        player.isWindy = true;
        player.windForce = this.windDirection * this.windStrength;
    }
    private void OnTriggerExit(Collider other) {
        player.isWindy = false;
        player.windForce = 0f;
    }
}
