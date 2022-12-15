using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinCounter : MonoBehaviour
{
    public int coinCount;
    public Text coinText;

    public void AddCoin() {
		    coinCount += 1;
        coinText.text = coinCount.ToString ("00");
	  }

    public int getCount(){
      return coinCount;
    }

    
}
