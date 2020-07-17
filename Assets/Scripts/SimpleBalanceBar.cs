using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleBalanceBar : MonoBehaviour
{
   public Slider balanceBar;
   public playerBalance playerBalance;

void Update(){
    balanceBar.value = playerBalance.currentBalance;
}

}

