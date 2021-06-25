using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IventText : MonoBehaviour
{
    /// <summary>
    ///  MesseageText------------
    /// </summary>
    [SerializeField]
    private GameObject canvas;

    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text dataText;
    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    public static TextAsset textAsset;
    //　テキストファイルから読み込んだデータ
    public static string loadText1;
    //   テキストファイルから読み込んだテキストから特殊コードを除いたデータ
    public static string loadText2;
    //　改行で分割して配列に入れる
    public static string[] splitText1;
    //    特殊コードを除いたデータを改行で分割して配列に入れる
    public static string[] splitText2;
    //　現在表示中テキスト1番号
    private int textNum1;

    /// <summary>
    /// NameText----------------
    /// </summary>
    //　読み込んだテキストを出力するUIテキスト
    [SerializeField] private GameObject nameText_w;
    [SerializeField] private GameObject nameText_m;
    [SerializeField] private GameObject nameText_s;

    /// <summary>
    /// 画像-------------------
    /// </summary>
    //画像のアクティブ取得用
    [SerializeField] private GameObject image_women;
    [SerializeField] private GameObject image_men;
    [SerializeField] private GameObject image_girl;
    [SerializeField] private GameObject girl;
    //Image取得(spriteを変更)
    [SerializeField] private Image women;
    [SerializeField] private Image men;
    //画像のSpriteを格納する配列
    Sprite[] WomenImage;
    Sprite[] MenImage;

    public static GameObject messageText;

    [SerializeField] private GameObject textbox;
    [SerializeField] private GameObject pagebleak;
    [SerializeField] private GameObject player;

    /// <summary>
    /// 特殊コード------------------------
    /// </summary>
    /*
      @1 =　女性の画像
      @2 =   男性の画像
      @3 =   Object　or  少女の画像
      @4 =   SE
      @~ A-G = 各画像の種類(人物の表情の切り替えや背景の切り替え)
     */

    //特殊コード処理用変数
    private string code;

    /// <summary>
    /// Sound---------------------
    /// </summary>
    [SerializeField] private AudioSource textSE;//TextのSE用のAudioSource
    [SerializeField] private AudioSource storySE;//StoryのSE用のAudioSource

    //TextのSE用のAudioClip
    [SerializeField] private AudioClip t_se1;
    [SerializeField] private AudioClip t_se2;

    //StoryのSE用のAudioClip
    [SerializeField] private AudioClip s_se1;
    [SerializeField] private AudioClip s_se2;
    [SerializeField] private AudioClip s_se3;
    [SerializeField] private AudioClip s_se4;
    [SerializeField] private AudioClip s_se5;
    [SerializeField] private AudioClip s_se6;
    [SerializeField] private AudioClip s_se7;
    [SerializeField] private AudioClip s_se8;

    // Canvasの状態管理
    public static bool Ivent_Image;

    public static GameObject gateWall;
    [SerializeField] private GameObject r_button;


    void Start()
    {
        //空に
        messageText = GameObject.Find("MessageText");
        messageText.GetComponent<Text>().text = "";

        r_button.SetActive(false);
        image_girl.SetActive(false);
        girl.SetActive(false);

        //Resourcesフォルダにある種類別に分けられたフォルダにあるすべて画像を配列に格納
        WomenImage = Resources.LoadAll<Sprite>("Image/Women/");
        MenImage = Resources.LoadAll<Sprite>("Image/Men/");

        //非アクティブ
        textbox.SetActive(false);

        //テキスト番号の初期化
        textNum1 = 0;

        gateWall = GameObject.Find("GateWall");
        gateWall.SetActive(false);

        //男性の名前
        nameText_m.SetActive(false);
        //女性の名前
        nameText_w.SetActive(false);
        //少女
        nameText_s.SetActive(false);

        //女性の画像
        image_women.SetActive(false);
        //男性の画像
        image_men.SetActive(false);
        //ページ送りPrefab
        pagebleak.SetActive(false);
    }

    void Update()
    {
        //Ivent_Imageがtrueになったら...
        if (Ivent_Image == true)
        {
            canvas.SetActive(true);
            //テキストBox画像をtrue
            textbox.SetActive(true);
            //左クリックが押されたら...
            if (Input.GetButtonDown("Fire1"))
            {
                //配列の長さがテキスト番号以下だったら...
                if (textNum1 < splitText1.Length)
                {
                    //取得した行の末尾の4文字目から3文字取得してcodeに代入する
                    //その行からcodeをReplaceすることで特殊コードを除いたTextになる
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
                            image_women.SetActive(true);
                            women.sprite = WomenImage[0];
                            image_men.SetActive(false);
                            image_girl.SetActive(false);
                            nameText_w.SetActive(true);
                            nameText_m.SetActive(false);
                            nameText_s.SetActive(false);
                            textSE.PlayOneShot(t_se1);
                            break;
                        case "@1B":
                            image_women.SetActive(true);
                            women.sprite = WomenImage[1];
                            image_men.SetActive(false);
                            image_girl.SetActive(false);
                            nameText_w.SetActive(true);
                            nameText_m.SetActive(false);
                            nameText_s.SetActive(false);
                            textSE.PlayOneShot(t_se1);
                            break;
                        case "@2A":
                            image_men.SetActive(true);
                            men.sprite = MenImage[0];
                            image_women.SetActive(false);
                            image_girl.SetActive(false);
                            nameText_w.SetActive(false);
                            nameText_m.SetActive(true);
                            nameText_s.SetActive(false);
                            textSE.PlayOneShot(t_se1);
                            break;
                        case "@3A":
                            gateWall.SetActive(true);
                            break;
                        case "@3B":
                            messageText.GetComponent<Text>().text = "先に進もう。";
                            break;
                        case "@3C":
                            image_girl.SetActive(true);
                            image_men.SetActive(false);
                            image_women.SetActive(false);
                            girl.SetActive(true);
                            nameText_w.SetActive(false);
                            nameText_m.SetActive(false);
                            nameText_s.SetActive(true);
                            break;
                        case "@3D":
                            player.transform.position = new Vector3(-25, -78.5f, 0);
                            r_button.SetActive(true);
                            CameraScript.roadCamera.SetActive(true);
                            CameraScript.nine_Camera.SetActive(false);
                            break;
                        case "@3E":
                            girl.SetActive(false);
                            image_girl.SetActive(false);
                            break;
                        case "@3F":
                            messageText.GetComponent<Text>().text = "色々な教室で手がかりを探して謎を解こう";
                            image_women.SetActive(false);
                            nameText_w.SetActive(false);
                            break;
                        case "@3G":
                            messageText.GetComponent<Text>().text = "謎は全て解けた。正門へ向かおう";
                            image_men.SetActive(false);
                            nameText_m.SetActive(false);
                            break;
                        case "   ":
                            image_men.SetActive(false);
                            image_women.SetActive(false);
                            image_girl.SetActive(false);
                            nameText_w.SetActive(false);
                            nameText_m.SetActive(false);
                            nameText_s.SetActive(false);
                            messageText.GetComponent<Text>().text = "";
                            break;
                    }

                    if (splitText1[textNum1] != "")
                    {
                        //改行されたデータ(配列)を代入してUIテキストに出力
                        //配列番号を+1
                        dataText.text = splitText2[textNum1];
                        textNum1++;

                        //ページ送りPrefab
                        pagebleak.SetActive(true);
                    }
                    else
                    {
                        //textの中身を空に
                        dataText.text = "";
                        textNum1++;
                    }
                }
                else
                {
                    //非アクティブ
                    Ivent_Image = false;
                    canvas.SetActive(false);

                    //プレイヤーも動きをアクティブ
                    PlayerController.isMove = true;

                    //Playerのspeedを4(通常)に
                    PlayerController.speed = 4;
                    textbox.SetActive(false);
                    image_men.SetActive(true);
                    image_women.SetActive(false);
                    dataText.text = "";
                    textNum1 = 0;
                }
            }
        }

    }

    public void Return()
    {
        player.transform.position = new Vector3(-25, -45.3f, 0);
        CameraScript.roadCamera.SetActive(false);
        CameraScript.nine_Camera.SetActive(true);
    }
}
