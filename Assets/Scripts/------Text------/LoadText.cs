
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class LoadText : MonoBehaviour
{
    /// <summary>
    ///  MesseageText------------
    /// </summary>
    //　読み込んだテキストを出力するUIテキスト
    [SerializeField]
    private Text dataText;
    //　読む込むテキストが書き込まれている.txtファイル
    [SerializeField]
    private TextAsset textAsset;
    //　テキストファイルから読み込んだデータ
    private string loadText1;
    //   テキストファイルから読み込んだテキストから特殊コードを除いたデータ
    public static string loadText2;
    //　改行で分割して配列に入れる
    private string[] splitText1;
    //    特殊コードを除いたデータを改行で分割して配列に入れる
    private string[] splitText2;
    //　現在表示中テキスト1番号
    private int textNum1;

    /// <summary>
    /// NameText----------------
    /// </summary>
    //　読み込んだテキストを出力するUIテキスト
    [SerializeField] private GameObject nameText_w;
    [SerializeField] private GameObject nameText_m;

    /// <summary>
    /// 特殊コード------------------------
    /// </summary>
    /*
      @1 =　女性の画像
      @2 =   男性の画像
      @3 =   背景
      @4 =   SE
      @5 =   BGM
      @~ A-G = 各画像の種類(人物の表情の切り替えや背景の切り替え)
    */

    //特殊コード処理用変数
    private string code;

    /// <summary>
    /// 画像-----------------------
    /// </summary>
    //画像のアクティブ取得用
    [SerializeField] private GameObject image_women;
    [SerializeField] private GameObject image_men;
    //Image取得(spriteを変更)
    [SerializeField] private Image women;
    [SerializeField] private Image men;
    [SerializeField] private Image backimage;

    //画像のSpriteを格納する配列
    Sprite[] BackImage;//背景
    Sprite[] WomenImage;//女性の画像
    Sprite[] MenImage;//男性の画像

    //メニュー
    [SerializeField] private GameObject menu;
    public Slider bgm_Slider;//bgm音量調整
    public Slider se_Slider;//se音量調整
    public Slider speed_Slider;//会話速度調整

    [SerializeField] private GameObject pagebleak;//クリックアイコン

    /// <summary>
    /// Sound---------------------
    /// </summary>
    [SerializeField] private AudioSource textSE;//TextのSE用のAudioSource
    [SerializeField] private AudioSource storyBGM1;// StoryのBGM用のAudioSource
    [SerializeField] private AudioSource storyBGM2;
    [SerializeField] private AudioSource storyBGM3;
    [SerializeField] private AudioSource storyBGM4;
    [SerializeField] private AudioSource storySE;//StoryのSE用のAudioSource
    [SerializeField] private AudioSource clickSE;//ClickのSE用のAudioSource

    //TextのSE用のAudioClip
    [SerializeField] private AudioClip t_se1;
    [SerializeField] private AudioClip t_se2;
    //StoryのBGM用のAudioClip
    [SerializeField] private AudioClip s_bgm1;

    //StoryのSE用のAudioClip
    [SerializeField] private AudioClip s_click;
    [SerializeField] private AudioClip s_se1;
    [SerializeField] private AudioClip s_se2;
    [SerializeField] private AudioClip s_se3;
    [SerializeField] private AudioClip s_se4;
    [SerializeField] private AudioClip s_se5;
    [SerializeField] private AudioClip s_se6;
    [SerializeField] private AudioClip s_se7;
    [SerializeField] private AudioClip s_se8;

    //コルーチン用の変数
    private float timer = 0;
    private float interval = 0.3f;

    //テキスト用の変数
    int textNumber;//何行目か
    int textCharNumber;//何文字目か
    string displayText;//表示するテキスト
    bool story_chk = true;//会話の状態
    bool auto_chk = false;//オート会話の状態
    int displayTextSpeed;//テキストの速さ

   float speed = 0;//Autoの速さ

    int menu_count = 0;//menuを開くカウンター
    int auto_count = 0;//Autoを押すカウンター
    int log_count = 0;//Logを押すカウンター

    [SerializeField]
    private GameObject log_canvas;
    [SerializeField]
    private ScrollRect backLog;

    private string m_name = "坂本　：　";
    private string w_name = "西園寺　：　";

    void Start()
    {
        //Resourcesフォルダにある種類別に分けられたフォルダにあるすべて画像を配列に格納
        BackImage = Resources.LoadAll<Sprite>("Image/BackGround/");
        WomenImage = Resources.LoadAll<Sprite>("Image/Women/");
        MenImage = Resources.LoadAll<Sprite>("Image/Men/");

        backimage.sprite = BackImage[0];//朝(校門)

        //BGM初期化
        storyBGM1.PlayOneShot(s_bgm1);
        storyBGM2.Pause();
        storyBGM3.Pause();
        storyBGM4.Pause();

        //読み込んだテキストデータを代入
        loadText1 = textAsset.text;
   
        //代入されたテキストデータを改行で分割して配列に入れる
        splitText1 = loadText1.Split(char.Parse("\n"));
        
        //テキスト番号の初期化
        textNum1 = 0;

        //名前を表示するUIテキストを取得して、非アクティブ
        //男性の名前
        nameText_m.SetActive(false);
        //女性の名前
        nameText_w.SetActive(false);

        //画像を取得して非アクティブ
        //女性の画像
        image_women.SetActive(false);
        //男性の画像
        image_men.SetActive(false);

        //メニュー
        menu.SetActive(false);

        //PageBleak
        pagebleak.SetActive(false);

        //Log
        log_canvas.SetActive(false);
    }

    void Update()
    {
        if (this.timer > 0)
        {
            this.timer -= Time.deltaTime;
        }

        displayTextSpeed++;//テキストの速さ

        if (story_chk)
        {
           
            string code0 = splitText1[textNumber][textCharNumber].ToString();//@
            string code1 = splitText1[textNumber][textCharNumber + 1].ToString() + splitText1[textNumber][textCharNumber + 2].ToString();//@に続く2文字
            //textファイル、末尾の特殊コードは3文字分(特殊コードの文字数分)空白にする
            if (code0 == "@")
            {
                Debug.Log(code1);
                Switch(code1);//特殊コード処理
                textCharNumber += 3;//code1の文字数分足す(テキストを飛ばす)
                return;
               

                /*return句とbreak句の違い*/
                //breakの場合はbreakを囲っているwhile文やfor文の繰り返しが終了し、次の処理に行くが、
                //returnの場合は、メソッドごと終了させる
            }

            //各行の最初の文字の時に一度だけ処理
            if (textCharNumber == 0 && textNumber < splitText1.Length + 1)
            {
                code = splitText1[textNumber].Substring(splitText1[textNumber].Length - 4, 3);
                loadText2 = loadText1.Replace(code, "");
                splitText2 = loadText2.Split(char.Parse("\n"));
                if (code0 != "@")
                {
                    backLog.content.GetComponentInChildren<Text>().text += splitText2[textNumber];
                }
               
            }

            if (textCharNumber != splitText2[textNumber].Length)//もしtext[textNumber]の文字列の文字が最後の文字じゃなければ
            {
                pagebleak.SetActive(false);
                displayText = displayText + splitText2[textNumber][textCharNumber];//displayTextに文字を追加していく
                //textファイル、末尾の特殊コードは2文字分(特殊コードの文字数分)空白にする
                textCharNumber = textCharNumber + 1;//次の文字にする
            }
            else //各行の末尾
            {
                //クリックボタン表示　
                pagebleak.SetActive(true);
                //現在の行番号が読み込むテキストの行の長さより-1小さくない場合
                if (textNumber != splitText2.Length - 1)
                {
                    //左クリックされた&&Autoボタンが押されていない時
                    if (Input.GetMouseButtonDown(0) && !auto_chk)
                    {
                        clickSE.PlayOneShot(s_click);//クリック音
                        storySE.Stop();

                        displayText = "";
                        textCharNumber = 0;//文字数リセット
                        textNumber = textNumber + 1;//次の行へ
                    }
                    else if (auto_chk)//Auto会話
                    {
                        if (displayTextSpeed % speed == 0)
                        {
                            storySE.Stop();

                            displayText = "";
                            textCharNumber = 0;//文字数リセット
                            textNumber = textNumber + 1;//次の行へ
                        }
                    }
                }
                else //テキストの最後の行
                {
                    story_chk = false;//会話停止
                    this.timer = this.interval;
                    textSE.PlayOneShot(t_se2);
                    StartCoroutine("NextScene");//次のシーン
                }
            }
            dataText.text = displayText;
       
        }
        
        //    //LinQ(リンク)　FirstOrDefaultメソッド
        //    //keysのシーケンス(配列)内の要素と合致した最初の要素を取り出す
        //    //string code = keys.FirstOrDefault<string>(s => splitText1[textNum1].Contains(s))

        if (textNum1 == splitText1.Length)
        {
           this.timer = this.interval;
            textSE.PlayOneShot(t_se2);
            StartCoroutine("NextScene");
        }

        //会話速度調整
        speed = 1000 * speed_Slider.GetComponent<Slider>().normalizedValue;

        //音量調整
        storySE.volume = se_Slider.GetComponent<Slider>().normalizedValue;
        storyBGM1.volume = bgm_Slider.GetComponent<Slider>().normalizedValue;
        storyBGM2.volume = bgm_Slider.GetComponent<Slider>().normalizedValue;
        storyBGM3.volume = bgm_Slider.GetComponent<Slider>().normalizedValue;
        storyBGM4.volume = bgm_Slider.GetComponent<Slider>().normalizedValue;
    }

    //特殊コード処理関数
    void Switch(string code)
    {
        string logtext = splitText2[textNumber].Replace("@" + code, "");
        
        //code(特殊コード)によって処理を変化
        switch (code)
        {
            //女性--------------------
            case "1A"://ノーマル
                women.sprite = WomenImage[0];
                Women("true");
                Men("false");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += w_name + logtext;
                break;
            case "1B"://笑顔(口開け)
                women.sprite = WomenImage[1];
                Women("true");
                Men("false");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += w_name + logtext;
                break;
            case "1C"://怒り・圧
                women.sprite = WomenImage[2];
                Women("true");
                Men("false");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += w_name + logtext;
                break;
            case "1D"://怒り・発言
                women.sprite = WomenImage[3];
                Women("true");
                Men("false");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += w_name + logtext;
                break;
            case "1E":///困り顔
                women.sprite = WomenImage[4];
                Women("true");
                Men("false");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += w_name + logtext;
                break;
            case "1F"://悲しい顔
                women.sprite = WomenImage[5];
                Women("true");
                Men("false");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += w_name + logtext;
                break;

                //男性--------------------
            case "2A"://困り顔(口閉じ)
                men.sprite = MenImage[0];
                Women("false");
                Men("true");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += m_name + logtext;
                break;
            case "2B"://困り顔(口開け)
                men.sprite = MenImage[1];
                Women("false");
                Men("true");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += m_name + logtext;
                break;
            case "2C"://ノーマル
                men.sprite = MenImage[2];
                Women("false");
                Men("true");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += m_name + logtext;
                break;
            case "2D"://目閉じ
                men.sprite = MenImage[3];
                Women("false");
                Men("true");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += m_name + logtext;
                break;
            case "2E"://笑顔(口閉じ)
                men.sprite = MenImage[4];
                Women("false");
                Men("true");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += m_name + logtext;
                break;
            case "2F"://笑顔(口開け)
                men.sprite = MenImage[5];
                Women("false");
                Men("true");
                textSE.PlayOneShot(t_se1);
                backLog.content.GetComponentInChildren<Text>().text += m_name + logtext;
                break;

                //背景----------------------
            case "3A"://夕方(部室)
                backimage.sprite = BackImage[7];
                break;
            case "3B"://夜(校門)
                backimage.sprite = BackImage[2];
                break;
            case "3C"://夜(部室)
                backimage.sprite = BackImage[5];
                break;
            case "3D"://夕方(校門)
                backimage.sprite = BackImage[1];
                break;

                //効果音----------------------
            case "4A":
                storySE.PlayOneShot(s_se1);
                backLog.content.GetComponentInChildren<Text>().text += logtext;
                break;
            case "4B":
                storySE.PlayOneShot(s_se2);
                backLog.content.GetComponentInChildren<Text>().text += logtext;
                break;
            case "4C":
                storySE.PlayOneShot(s_se3);
                backLog.content.GetComponentInChildren<Text>().text += logtext;
                break;
            case "4D":
                storySE.PlayOneShot(s_se4);
                backLog.content.GetComponentInChildren<Text>().text += logtext;
                break;
            case "4E":
                Denwa();
                Invoke("Denwa", 2.5f);
                Invoke("Denwa", 5f);
                backLog.content.GetComponentInChildren<Text>().text += logtext;
                break;
            case "4F":
                storySE.PlayOneShot(s_se6);
                backLog.content.GetComponentInChildren<Text>().text += logtext;
                break;
            case "4G":
                storySE.PlayOneShot(s_se7);
                backLog.content.GetComponentInChildren<Text>().text += logtext;
                break;
            case "4H":
                storySE.PlayOneShot(s_se8);
                backLog.content.GetComponentInChildren<Text>().text += logtext;
                break;

                //BGM----------------------
            case "5A":
                storyBGM2.UnPause();
                storyBGM1.Pause();
                storyBGM3.Pause();
                storyBGM4.Pause();
                Men("false");
                Women("false");
                break;
            case "5B":
                storyBGM3.UnPause();
                storyBGM2.Pause();
                storyBGM4.Pause();
                Men("false");
                Women("false");
                break;
            case "5C":
                storyBGM4.UnPause();
                storyBGM3.Pause();
                Men("false");
                Women("false");
                break;


            case "   ":
                Men("false");
                Women("false");
                break;
        }
    }

    //次のシーンへのWait(Delay)
    IEnumerator NextScene()
    {
        //何秒後...
        yield return new WaitForSeconds(1.0f);

        SceneManager.LoadScene("MainScene");
    }
    
    //着信音　
    void Denwa()
    {
        storySE.PlayOneShot(s_se5);
    }

    //スキップボタン
    public void Skip()
    {
        textNumber = splitText1.Length - 2;
    }

    //ログボタン
    public void Log()
    {
        log_count++;
        if (log_count % 2 == 0)
        {
            log_canvas.SetActive(false);
            story_chk = true;
        }
        else
        {
            log_canvas.SetActive(true);
            story_chk = false;
        }
    }

    //オートボタン
    public void Auto()
    {
        auto_count++;
        if (auto_count % 2 == 0)
        {
            auto_chk = false;
        }
        else
        {
            auto_chk = true;
        }
    }

    //メニューボタン
    public void Menu()
    {
        menu_count++;
        if (menu_count % 2 == 0)
        {
            menu.SetActive(false);
            story_chk = true;
        }
        else
        {
            menu.SetActive(true);
            story_chk = false;
        }
    }

    void Men(string answer){
        switch (answer) {
            case "true":
                image_men.SetActive(true);
                nameText_m.SetActive(true);
                break;
            case "false":
                image_men.SetActive(false);
                nameText_m.SetActive(false);
                break;
        }
    }

    void Women(string answer)
    {
        switch (answer)
        {
            case "true":
                image_women.SetActive(true);
                nameText_w.SetActive(true);
                break;
            case "false":
                image_women.SetActive(false);
                nameText_w.SetActive(false);
                break;
        }
    }
}
