using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialNumber : MonoBehaviour
{

    [SerializeField] TMP_Text numberText = default; //表示するためのもの
    public int number = 0; //数字

    //クリックされると数字を増やす
    public void Onclick()
    {
        number++; //numberに1を足す

        if (number > 9) //numberが9を超えたら0に戻す
        {
            number = 0;
        }

        numberText.text = number.ToString(); //数字をテキストに反映して表示する
    }
}
