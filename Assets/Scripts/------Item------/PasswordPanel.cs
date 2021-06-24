using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PasswordPanel : MonoBehaviour
{
    public GameObject messageText;

    //正解の数字
    int[] correctAnswer = { 3, 0, 1, 1 };

    //ユーザの入力
    [SerializeField] DialNumber[] dialNumbers = default;

    public void OnClickButton()
    {
        if (CheckClear())
        {
            messageText.GetComponent<Text>().text = "正解！";
            PlayerController.Count += 1;
        }
    }

    //正解とユーザの入力を確かめる
    bool CheckClear()
    {
        for (int i = 0; i < dialNumbers.Length; i++)
        {
            if (dialNumbers[i].number != correctAnswer[i])
            {
                return false; //一致しない場合
            }
        }
        return true;
    }
}