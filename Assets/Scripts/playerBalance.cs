using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBalance : MonoBehaviour
{
    public float currentBalance = 0.0f;
    public float maxRightLean = 45.0f;
    public float maxLeftLean = -45.0f;

    public float counterBalanceStrength = 2.0f;

    //public float windStrength = 1.0f;
    public bool isWindy = false;
    public float windForce = 0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(rb.)
        
        updateBalance();
    }


void updateBalance(){
    if(isWindy){
        currentBalance += windForce;
    }
    
    if(Input.GetKey(KeyCode.L) && currentBalance <= maxRightLean){
            currentBalance += counterBalanceStrength;
        }
    if(Input.GetKey(KeyCode.K) && currentBalance >= maxLeftLean)
    {
        currentBalance -= counterBalanceStrength;
    }
    
    if(currentBalance <= maxLeftLean){
        Debug.Log("You fell to the left");
    }
    if(currentBalance >= maxRightLean){
        Debug.Log("You fell off to the right");
    }
}
}
