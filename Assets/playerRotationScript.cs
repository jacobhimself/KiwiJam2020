using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotationScript : MonoBehaviour
{
    public playerBalance pB;
    public Transform playerMesh;
    public Transform pivotal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        //playerMesh.transform.RotateAround(pivotal.position,new Vector3(0,0,1), pB.currentBalance);
        playerMesh.transform.rotation = Quaternion.Euler(0,90,-pB.currentBalance);
    }
}
