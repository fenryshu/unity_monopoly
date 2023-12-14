using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class randomNumber : MonoBehaviour
{
    public manager_Turn C_manager_Turn;
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
        C_manager_Turn.runTurn(number);
    }

    public static int Random_number(){
        int number_;
        number_ = Random.Range(1,6);
        return number_;
    }


}
