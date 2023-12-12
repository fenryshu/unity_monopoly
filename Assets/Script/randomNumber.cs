using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class randomNumber : MonoBehaviour
{
    public player c_player;
     public TextMeshProUGUI txt_number;
    
    public int number;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Bnt_random(){
        number = Random_number();
        txt_number.text = number.ToString();
        c_player.enter_numberBox(number);
    }

    public static int Random_number(){
        int number_;
        number_ = Random.Range(1,6);
        return number_;
    }


}
