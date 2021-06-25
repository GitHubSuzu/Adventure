using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    //歩行SE
    public static AudioSource WalkSound;
    //アニメーション宣言
    public static Animator anim;
    //Rigidbody宣言
    public static Rigidbody2D rb;
    //Playerの歩く速度
    public static float speed = 4;
    //SE(ドアを開ける音)の状態管理
    public static int Change { private set; get; } = 1;
    //Playerのy座標の速度
    float ySpeed = 0.0f;
    //Playerの動きの状態管理
    public static bool isMove = true;
    //イベントのカウンター
    public static int ivent = 0;
    public static int No;
    public static int Count = 0;

    [SerializeField]
    private AudioSource audioSource1;
    [SerializeField]
    private AudioSource audioSource2;

    [SerializeField] private AudioClip bgm1;
    [SerializeField] private AudioClip bgm2;

    public Slider bgm_Slider;
    public Slider speed_Slider;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        WalkSound = GetComponent<AudioSource>();
    }

    private void Awake()
    {
        //plyerの数を取得
        int Players = FindObjectsOfType<PlayerController>().Length;
        //playerの数が1以上の場合そのPlayerを消す
        if (Players > 1)
        {
            Destroy(this.gameObject);
        }
        else//Playerを他のシーンでも扱えるようにする
        {
            DontDestroyOnLoad(this);
        }
    }

void Update()
    {
        Debug.Log(speed);

        if(Count == 2)
        {
            ivent = 7;
        }
        
        //*以後要修正*
        //Playerの動きが非アクティブの時上方向に進む
        if (!isMove)
        {
            ySpeed = speed * 0.5f;
            rb.velocity = new Vector2(0, ySpeed);
        }
        //Playerが動きがアクティブの時操作可能にする
        if (isMove)
        {
            PlayerMove();
        }
        audioSource1.volume = bgm_Slider.GetComponent<Slider>().normalizedValue;
        audioSource2.volume = bgm_Slider.GetComponent<Slider>().normalizedValue;
    }

    /// <summary>
    /// 移動処理--------------------
    /// </summary>
    public void PlayerMove()
    {
        //Playerのx,yの値を宣言し初期化
        float ySpeed = 0.0f;
        float xSpeed = 0.0f;
    
            //上下移動---------------
            if (Input.GetKey(KeyCode.S))//下
            {
           　 //Animation切り替え
         　    anim.SetBool("down", true); //下へ歩く Animation
           　  anim.SetBool("down_stand", false); //下向きに立ち止まる　Animation
          　   anim.SetBool("run", false);
                ySpeed = -speed;//ｙの値からspeedの速さ-する
                WalkSound.UnPause();//歩行SE
            }
            else if (Input.GetKey(KeyCode.W))//上
            {
                //Animation切り替え
                anim.SetBool("up", true);  //上へ歩く Animation
                anim.SetBool("up_stand", false);//上向きに立ち止まる　Animation
                anim.SetBool("run", false); 
                ySpeed = speed;//yの値からspeedの速さ+する
                WalkSound.UnPause();
            }
            //左右移動--------------
            else if (Input.GetKey(KeyCode.D))// 右
            {
                transform.localScale = new Vector3(-1, 1, 1);
                anim.SetBool("run", true);//左右に歩く Animation
         　    anim.SetBool("left_stand", false);//左右に立ち止まる　Animation
                anim.SetBool("up", false);
                anim.SetBool("down", false);
                xSpeed = speed;//xの値からspeedの速さ+する
                WalkSound.UnPause();
            }
            else if (Input.GetKey(KeyCode.A))//左
            {
                transform.localScale = new Vector3(1, 1, 1);
                anim.SetBool("run", true);
                anim.SetBool("left_stand", false);//左右に立ち止まる　Animation
            　 anim.SetBool("up", false);
                anim.SetBool("down", false);
                xSpeed = -speed;//xの値からspeedの速さ-する
                WalkSound.UnPause();
            }
            else
            {
                anim.SetBool("down_stand", true);
                anim.SetBool("up_stand", true);
                anim.SetBool("up", false);
                anim.SetBool("down", false);
                anim.SetBool("run", false);
                anim.SetBool("left_stand", true);
                ySpeed = 0.0f;
                xSpeed = 0.0f;
                WalkSound.Pause();
            }
            rb.velocity = new Vector2(xSpeed, ySpeed);
        
    }

    /// <summary>
    /// 衝突判定----------------------
    /// </summary>
    /// <param name="collision"></param>
    //触れている最中だけ判定
    private void OnTriggerStay2D(Collider2D collision)
    {
        //objectにセットされたtagに応じて...
        switch (collision.gameObject.tag)
        {
            //ゴミ箱に触れたら...
            case "Gomi":
                collision.gameObject.GetComponent<ItemManager>().GomiBako();
                break;
            case "Signboard":
                collision.gameObject.GetComponent<ItemManager>().Signboard();
                break;
            case "Bed":
                collision.gameObject.GetComponent<ItemManager>().Bed();
                break;
            case "Getabako":
                collision.gameObject.GetComponent<ItemManager>().Getabako();
                break;
            case "Bookshelf":
                collision.gameObject.GetComponent<ItemManager>().Bookshelf();
                break;
            case "Blackboard":
                collision.gameObject.GetComponent<ItemManager>().Blackboard();
                break;
            case "Book":
                collision.gameObject.GetComponent<ItemManager>().Book();
                break;
            case "Cardboard":
                collision.gameObject.GetComponent<ItemManager>().Cardboard();
                break;
            case "Desk":
                collision.gameObject.GetComponent<ItemManager>().Desk();
                break;
            case "Case":
                collision.gameObject.GetComponent<ItemManager>().Case();
                break;
            case "Watercrew":
                collision.gameObject.GetComponent<ItemManager>().Watercrew();
                break;
            case "Window":
                collision.gameObject.GetComponent<ItemManager>().Window();
                break;
            case "Kaban":
                collision.gameObject.GetComponent<ItemManager>().Kaban();
                break;
            case "Chair":
                collision.gameObject.GetComponent<ItemManager>().Chair();
                break;
            case "Kamikuzu_1":
                collision.gameObject.GetComponent<ItemManager>().Kamikuzu_1();
                break;
            case "Kamikuzu_2":
                collision.gameObject.GetComponent<ItemManager>().Kamikuzu_2();
                break;
            case "Stove":
                collision.gameObject.GetComponent<ItemManager>().Stove();
                break;
            case "Bottle":
                collision.gameObject.GetComponent<ItemManager>().Bottle();
                break;
            case "Test":
                collision.gameObject.GetComponent<ItemManager>().Test();
                break;
            case "Umbrellastand":
                collision.gameObject.GetComponent<ItemManager>().Umbrellastand();
                break;
            case "Paper":
                collision.gameObject.GetComponent<ItemManager>().Paper();
                break;
            case "Report":
                collision.gameObject.GetComponent<ItemManager>().Report();
                break;
            case "Bucket_1":
                collision.gameObject.GetComponent<ItemManager>().Bucket_1();
                break;
            case "Bucket_2":
                collision.gameObject.GetComponent<ItemManager>().Bucket_2();
                break;
            case "Locker":
                collision.gameObject.GetComponent<ItemManager>().Locker();
                break;
            case "Mop":
                collision.gameObject.GetComponent<ItemManager>().Mop();
                break;
            case "Materialshelf":
                collision.gameObject.GetComponent<ItemManager>().Materialshelf();
                break;
            case "Model_1":
                collision.gameObject.GetComponent<ItemManager>().Model_1();
                break;
            case "Model_2":
                collision.gameObject.GetComponent<ItemManager>().Model_2();
                break;
            case "Mirror_1":
                collision.gameObject.GetComponent<ItemManager>().Mirror_1();
                break;
            case "Mirror_2":
                collision.gameObject.GetComponent<ItemManager>().Mirror_2();
                break;
        }
    }

    //触れた瞬間に判定
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //objectにセットされたtagに応じて...
        switch (collision.gameObject.tag)
        {
            case "First_Ivent":
                if(ivent == 0)
                {
                    collision.gameObject.GetComponent<ItemManager>().FristIvent();
                    audioSource1.PlayOneShot(bgm1);
                }
                break;
            case "Front_Ivent":
                if (ivent == 1)
                {
                    collision.gameObject.GetComponent<ItemManager>().FrontIvent();
                }
                break;
            case "Front_Action":
                if (ivent == 2)
                {
                    collision.gameObject.GetComponent<ItemManager>().FrontAction();
                }
                break;
            case "Ivent_4":
                if(ivent == 4)
                {
                    collision.gameObject.GetComponent<ItemManager>().Ivent4();
                }
                break;
            case "Ivent_5":
                if (ivent == 5)
                {
                    collision.gameObject.GetComponent<ItemManager>().Ivent5();
                }
                break;
            case "Ivent_6":
                if (ivent == 6)
                {
                    collision.gameObject.GetComponent<ItemManager>().Ivent6();
                }
                break;
            case "Ivent_7":
                if (ivent == 7)
                {
                    collision.gameObject.GetComponent<ItemManager>().Ivent7();
                }
                break;
            case "Ivent_9":
                if (ivent == 9)
                {
                    collision.gameObject.GetComponent<ItemManager>().Ivent9();
                }
                break;
        }
    }

    //触れた瞬間に判定
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //objectにセットされたtagに応じて...
        switch (collision.gameObject.tag)
        {
            case "Up_C-Room_L":
                Change = 1;
                No = 1;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_up();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Corridor_Up(No);
                break;
            case "Up_Room":
                Change = 1;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_up();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Elevator_Up();
                break;
            case "Down_Room":
                Change = 1;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_down();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Elevator_Up();
                break;
            case "Up_Room2":
                Change = 0;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_up();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Elevator_Up();
                break;
            case "Down_Room2":
                Change = 0;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_down();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Elevator_Up();
                break;
            case "Down_C-Room_R":
                Change = 1;
                No = 1;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_down();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Corridor_Down(No);
                break;
            case "Up_Science_Room":
                Change = 1;
                No = 2;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_up();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Corridor_Up(No);
                break;
            case "Down_Stuff_Room":
                Change = 1;
                No = 2;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_down();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Corridor_Down(No);
                break;
            case "Up_Infirmary_Room":
                    Change = 1;
                    No = 3;
                    collision.gameObject.GetComponent<ChaseScript>().Teleport_up();
                    GameObject.Find("SceneManager").GetComponent<CameraScript>().Corridor_Up(No);
                break;
            case "Up_C_Room":
                Change = 1;
                No = 4;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_up();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Corridor_Up(No);
                break;
            case "Down_C_Room":
                Change = 1;
                No = 3;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_down();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Corridor_Down(No);
                break;
            case "Left_Teleport":
                collision.gameObject.GetComponent<ChaseScript>().Teleport_Left();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Elevator_Up();
                break;
            case "Right_Teleport":
                collision.gameObject.GetComponent<ChaseScript>().Teleport_Right();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Elevator_Up();
                break;
            case "Left_Teleport2":
                No = 4;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_Left();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Corridor_Up(No);
                break;
            case "Right_Teleport2":
                No = 4;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_Right();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Corridor_Up(No);
                break;
            case "Elevator_Up":
                Change = 0;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_up();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Elevator_Up();
                break;
            case "Up_Ivent":
                collision.gameObject.GetComponent<ChaseScript>().Up_Ivent();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Rood_up();
                audioSource1.Pause();
                audioSource2.PlayOneShot(bgm2);
                break;
            case "Up_Front":
                if (ivent > 3)
                {
                    collision.gameObject.GetComponent<ChaseScript>().Teleport_up();
                    GameObject.Find("SceneManager").GetComponent<CameraScript>().Front_up();
                }else
                {
                    collision.gameObject.GetComponent<ItemManager>().Door();
                }
                    break;
            case "Down_Elevator":
                collision.gameObject.GetComponent<ChaseScript>().Teleport_down();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Front_up();
                break;
            case "Down_Front":
                collision.gameObject.GetComponent<ChaseScript>().Teleport_down();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Rood_up();
                break;
            case "Left_Toilet":
                No = 1;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_Left();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Toilet(No);
                break;
            case "Right_Toilet":
                No = 2;
                collision.gameObject.GetComponent<ChaseScript>().Teleport_Right();
                GameObject.Find("SceneManager").GetComponent<CameraScript>().Toilet(No);
                break;
            case "Main_Gate":
                if (ivent == 3)
                {
                    collision.gameObject.GetComponent<ItemManager>().MainGate();
                    speed = 0;
                }
                else if(ivent == 8 || ivent == 10)
                {
                    EscapeManager.passwordCanvas.SetActive(true);
                }
                break;
            case "Escape":
                GameObject.Find("SceneManager").GetComponent<SceneChange>().ResultScene();
                audioSource2.Pause();
                break;
        }
    }

    public void Save()
    {
        audioSource1.Stop();
        audioSource2.Stop();
    }
}
