using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleBalanceBar : MonoBehaviour
{
   public Slider balanceBar;
   public playerBalance playerBalance;

void Start() {
    balanceBar.minValue = -45.0f;
    balanceBar.maxValue = 45.0f;    
}

void Update(){
    balanceBar.value = playerBalance.currentBalance;
}

}

