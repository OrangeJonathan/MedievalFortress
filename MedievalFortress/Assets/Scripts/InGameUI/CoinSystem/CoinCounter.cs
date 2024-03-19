using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;
public class CoinCounter : MonoBehaviour
{


    public static CoinCounter instance;
    public TMP_Text coinText;
    //start coins on wave 1 = 100
    public int currentCoins = 100000;
    
    void Awake()
    {
        instance = this;
        coinText.text = currentCoins.ToString();    
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void IncreaseCoins(int value) 
    {
        currentCoins += value;
        coinText.text = currentCoins.ToString();
    }
    public void DecreaseCoins(int value) 
    {
        currentCoins -= value;
        coinText.text = currentCoins.ToString();
    }

    
}
