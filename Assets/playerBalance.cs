using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBalance : MonoBehaviour
{
    public float currentBalance = 0.0f;
    public float maxRightLean = 45.0f;
    public float maxleftLean = -45.0f;

    public float counterBalanceStrength = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        updateBalance();
    }


void updateBalance(){
    if(Input.GetKey(KeyCode.L)){
            currentBalance += counterBalanceStrength;
        }
        if(Input.GetKey(KeyCode.K)){
            currentBalance -= counterBalanceStrength;
        }
        
        if(currentBalance <= maxleftLean){
            Debug.Log("You fell to the left");
        }
        if(currentBalance >= maxRightLean){
            Debug.Log("You fell off to the right");
        }
}
}
