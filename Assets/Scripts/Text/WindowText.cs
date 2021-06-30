using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WindowText : MonoBehaviour
{
    //Windowのテキストを表示するCanvas
    [SerializeField]
    private GameObject canvas_window;
    //　正門(Gate)を宣言
    public static GameObject gate;
    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text dataText;
    //　読む込むテキストが書き込まれている.txtファイル
    public static TextAsset textAsset;
    //　テキストファイルから読み込んだデータ
    public static string loadText1;
    //   テキストファイルから読み込んだテキストから特殊コードを除いたデータ
    public static string loadText2;
    //　改行で分割して配列に入れる
    public static string[] splitText1;
    //    特殊コードを除いたデータを改行で分割して配列に入れる
    private string[] splitText2;
    //　現在表示中テキスト1番号
    private int textNum1;
    // Canvasの状態管理
    public static bool isImage;


    [SerializeField] private GameObject canvas_pass;
    [SerializeField] private GameObject canvas_flick;
    /// <summary>
    /// 特殊コード------------------------
    /// </summary>
    /*
      @1 =　SE
      @2 =   Object
      @~ A-G = 各画像の種類(人物の表情の切り替えや背景の切り替え)
     */

    //特殊コード処理用変数
    private string code;

    /// <summary>
    /// Sound---------------------
    /// </summary>
    //TextのSE用のAudioSource
    [SerializeField] private AudioSource textSE;
    //TextのSE用のAudioClip
    [SerializeField] private AudioClip t_se1;
    [SerializeField] private AudioClip t_se2;
    [SerializeField] private AudioClip t_se3;
    [SerializeField] private AudioClip t_se4;
    [SerializeField] private AudioClip t_se5;
    [SerializeField] private AudioClip t_se6;

    void Start()
    {
        canvas_pass.SetActive(false);
        canvas_flick.SetActive(false);
        canvas_window.SetActive(false);
        gate = GameObject.FindGameObjectWithTag("Main_Gate");//処理が軽い
        //gate = GameObject.Find("Gate");
        gate.SetActive(false);
        textNum1 = 0;
    }

    void Update()
    {
        if (isImage == true)
        {
            canvas_window.SetActive(true);
            if (Input.GetButtonDown("Fire1"))
            {
                if (textNum1 < splitText1.Length)
                {
                    if (splitText1[textNum1].Length > 3)
                    {
                        code = splitText1[textNum1].Substring(splitText1[textNum1].Length - 4, 3);
                        loadText2 = loadText1.Replace(code, "");
                        splitText2 = loadText2.Split(char.Parse("\n"));
                    }

                    //code(特殊コード)によって処理を変化
                    switch (code)
                    {
                        case "@1A":
                            textSE.PlayOneShot(t_se1);
                            break;
                        case "@1B":
                            textSE.PlayOneShot(t_se2);
                            break;
                        case "@2A":
                            IventText.gateWall.SetActive(false);
                            IventText.messageText.GetComponent<Text>().text = "門のところへ行ってみよう";
                            break;
                        case "@2B":
                            IventText.messageText.GetComponent<Text>().text = "そのまま真っ直ぐ進んだ先にある部屋へ行こう。";
                            break;
                        case "@2C":
                            canvas_pass.SetActive(true);
                            break;
                        case "@2D":
                            canvas_flick.SetActive(true);
                            break;
                        case "   ":
                            IventText.messageText.GetComponent<Text>().text = "";
                            break;
                    }

                    if (splitText1[textNum1] != "")
                    {
                        dataText.text = splitText2[textNum1];
                        textNum1++;
                    }
                    else
                    {
                        dataText.text = "";
                        textNum1++;
                    }
                }
                else
                {
                    isImage = false;
                    canvas_window.SetActive(false);
                    PlayerController.isMove = true;
                    //PlayerController.isMove_Item = true;
                    PlayerController.speed = 4;
                    dataText.text = "";
                    textNum1 = 0;
                }
            }
        }
    }

    public void Back()
    {
        canvas_pass.SetActive(false);
        canvas_flick.SetActive(false);
        //Flick.TileA.transform.position = new Vector3(0, 0, 0);
    }
}
