using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeManager : MonoBehaviour
{

    public  static GameObject passwordCanvas; //パスワードを表示するCanvas
    public GameObject messageText; //メッセージテキスト
    InputField inputField;　//パスワード入力ボックス
    public const string TruePASS = "杏"; 　//正解のパスワード

    void Start()
    {
        //inputFieldのInputFieldコンポーネントを取得
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        //パスワードを表示するCanvasを取得
        passwordCanvas = GameObject.Find("Canvas_Escape");
        //非アクティブ(初期化)
        passwordCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PushButtonEnter()
    {
        //inputFieldに入力した文字列をpass(変数)に代入
        string pass = inputField.text;

        //入力された文字列と正解のパスワードを比較する
        //trueだったら
        if (pass.ToLower() == TruePASS.ToLower())
        {
            DisplayMessagePC("正解！▼");
            WindowText.gate.SetActive(false);    //オブジェクト(Gate)を非アクティブ
             passwordCanvas.SetActive(false);     //Canvasを消す
            inputField.text = "";     //InputFieldの文字を消す
        }
        else//falseだったら
        {
            DisplayMessagePC("不正解！▼");
        }
    }

    //PCメッセージを表示
    void DisplayMessagePC(string message)
    {
        //引数にセットされた文字列を表示する
        messageText.GetComponent<Text>().text = message;
    }

    //Back(PC)を押した
    public void PushButtonBackfromPC()
    {
        passwordCanvas.SetActive(false);     //Canvasを消す
        inputField.text = "";     //InputFieldの文字を消す
        messageText.GetComponent<Text>().text = "";
        if(PlayerController.ivent == 8)
        {
            Ivent8();
            PlayerController.speed = 0;
        }
    }

    public void Ivent8()
    {
        PlayerController.ivent = 9;
        Release();
        //IventTextのCanvasをアクティブ
        IventText.Ivent_Image = true;
        //ResourcesフォルダにあるMessageTextというテキストファイルを読み込む
        IventText.textAsset = Resources.Load("Story_5") as TextAsset;
        //読み込んだテキストデータを代入
        IventText.loadText1 = IventText.textAsset.text;
        //代入されたテキストデータを改行で分割して配列に入れる
        IventText.splitText1 = IventText.loadText1.Split(char.Parse("\n"));
    }

    //静止
    public void Release()
    {
        PlayerController.isMove = true;
    }
}