using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{



    void Start()
    {

    }

    void Update()
    {

    }


    public void Getabako()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Getabako") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Bookshelf()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Bookshelf") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Blackboard()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Blackboard") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Book()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Book") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Cardboard()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Cardboard") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Desk()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Desk") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Case()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Case") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Watercrew()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Watercrew") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Window()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Window") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Kaban()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Kaban") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Chair()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Chair") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Kamikuzu_1()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Kamikuzu_1") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Kamikuzu_2()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Kamikuzu_2") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Stove()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Stove") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Bottle()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Bottle") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Test()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Test") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Umbrellastand()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Umbrellastand") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Paper()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Paper") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Report()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Report") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Bucket_1()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Bucket_1") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Bucket_2()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Bucket_2") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Locker()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Locker") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Mop()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Mop") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Materialshelf()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Materialshelf") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Model_1()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Model_1") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Model_2()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Model_2") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Mirror_1()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Mirror_1") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }
    public void Mirror_2()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Mirror_2") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }



    public void Bed()
    {
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Bed") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }

    public void GomiBako()
    {
        //Enterキーが押されたら
        if (Input.GetMouseButtonDown(0) )
        {
           Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("Gomibako") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }

    public void Signboard()
    {
        //Enterキーが押されたら
        if (Input.GetMouseButtonDown(0) )
        {
            //Playerの動きを非アクティブ
            Freeze();
            //WindowTextのCanvasをアクティブ
            WindowText.isImage = true;
            //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
            WindowText.textAsset = Resources.Load("SignText") as TextAsset;
            //読み込んだテキストデータを代入
            WindowText.loadText1 = WindowText.textAsset.text;
            //代入されたテキストデータを改行で分割して配列に入れる
            WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
        }
    }

    public void Door()
    {
       Freeze();
        //WindowTextのCanvasをアクティブ
        WindowText.isImage = true;
        //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
        WindowText.textAsset = Resources.Load("DoorText_E") as TextAsset;
        //読み込んだテキストデータを代入
        WindowText.loadText1 = WindowText.textAsset.text;
        //代入されたテキストデータを改行で分割して配列に入れる
        WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
    }

    public void FristIvent()
    {
        PlayerController.ivent = 1;
       Freeze();
        //IventTextのCanvasをアクティブ
        IventText.Ivent_Image = true;
        //ResourcesフォルダにあるMessageTextというテキストファイルを読み込む
        IventText.textAsset = Resources.Load("FirstIvent_M") as TextAsset;
        //読み込んだテキストデータを代入
        IventText.loadText1 = IventText.textAsset.text;
        //代入されたテキストデータを改行で分割して配列に入れる
        IventText.splitText1 = IventText.loadText1.Split(char.Parse("\n"));
    }

    public void FrontIvent()
    {
        PlayerController.ivent = 2;
       Freeze();
        //IventTextのCanvasをアクティブ
        IventText.Ivent_Image = true;
        //ResourcesフォルダにあるMessageTextというテキストファイルを読み込む
        IventText.textAsset = Resources.Load("Front_M") as TextAsset; 
        //読み込んだテキストデータを代入
        IventText.loadText1 = IventText.textAsset.text;  
        //代入されたテキストデータを改行で分割して配列に入れる
        IventText.splitText1 = IventText.loadText1.Split(char.Parse("\n"));
    }

    public void FrontAction()
    {
        PlayerController.ivent = 3;
       Freeze();
        //Gate(Object)をアクティブ
        WindowText.gate.SetActive(true);
        //WindowTextのCanvasをアクティブ
        WindowText.isImage = true;
        //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
        WindowText.textAsset = Resources.Load("FrontAction") as TextAsset;
        //読み込んだテキストデータを代入
        WindowText.loadText1 = WindowText.textAsset.text;
        //代入されたテキストデータを改行で分割して配列に入れる
        WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
    }

    public void MainGate()
    {
        PlayerController.ivent = 4;
       Freeze();
        //IventTextのCanvasをアクティブ
        IventText.Ivent_Image = true;
        //ResourcesフォルダにあるMessageTextというテキストファイルを読み込む
        IventText.textAsset = Resources.Load("MainGate_M") as TextAsset;
        //読み込んだテキストデータを代入
        IventText.loadText1 = IventText.textAsset.text;
        //代入されたテキストデータを改行で分割して配列に入れる
        IventText.splitText1 = IventText.loadText1.Split(char.Parse("\n"));
    }

    public void  Ivent4()
    {
        PlayerController.ivent = 5;
       Freeze();
        //WindowTextのCanvasをアクティブ
        WindowText.isImage = true;
        //ResourcesフォルダにあるSignTextというテキストファイルを読み込む
        WindowText.textAsset = Resources.Load("Story_1") as TextAsset;
        //読み込んだテキストデータを代入
        WindowText.loadText1 = WindowText.textAsset.text;
        //代入されたテキストデータを改行で分割して配列に入れる
        WindowText.splitText1 = WindowText.loadText1.Split(char.Parse("\n"));
    }

   public void Ivent5()
    {
        PlayerController.ivent = 6;
       Freeze();
        //IventTextのCanvasをアクティブ
        IventText.Ivent_Image = true;
        //ResourcesフォルダにあるMessageTextというテキストファイルを読み込む
        IventText.textAsset = Resources.Load("Story_2") as TextAsset;
        //読み込んだテキストデータを代入
        IventText.loadText1 = IventText.textAsset.text;
        //代入されたテキストデータを改行で分割して配列に入れる
        IventText.splitText1 = IventText.loadText1.Split(char.Parse("\n"));
    }

    public void Ivent6()
    {
        PlayerController.ivent = 7;
       Freeze();
        //IventTextのCanvasをアクティブ
        IventText.Ivent_Image = true;
        //ResourcesフォルダにあるMessageTextというテキストファイルを読み込む
        IventText.textAsset = Resources.Load("Story_3") as TextAsset;
        //読み込んだテキストデータを代入
        IventText.loadText1 = IventText.textAsset.text;
        //代入されたテキストデータを改行で分割して配列に入れる
        IventText.splitText1 = IventText.loadText1.Split(char.Parse("\n"));
    }

    public void Ivent7()
    {
        PlayerController.ivent = 8;
        PlayerController.Count = 3;
       Freeze();
        //IventTextのCanvasをアクティブ
        IventText.Ivent_Image = true;
        //ResourcesフォルダにあるMessageTextというテキストファイルを読み込む
        IventText.textAsset = Resources.Load("Story_4") as TextAsset;
        //読み込んだテキストデータを代入
        IventText.loadText1 = IventText.textAsset.text;
        //代入されたテキストデータを改行で分割して配列に入れる
        IventText.splitText1 = IventText.loadText1.Split(char.Parse("\n"));
    }

    public void Ivent9()
    {
        PlayerController.ivent = 10;
       Freeze();
        //IventTextのCanvasをアクティブ
        IventText.Ivent_Image = true;
        //ResourcesフォルダにあるMessageTextというテキストファイルを読み込む
        IventText.textAsset = Resources.Load("Story_6") as TextAsset;
        //読み込んだテキストデータを代入
        IventText.loadText1 = IventText.textAsset.text;
        //代入されたテキストデータを改行で分割して配列に入れる
        IventText.splitText1 = IventText.loadText1.Split(char.Parse("\n"));
    }


    //Player制御処理関数-------
    //運動
    public void Freeze()
    {
        PlayerController.isMove = false;
        PlayerController.WalkSound.Pause();
        PlayerController.speed = 0;
        PlayerController.anim.SetBool("down_stand", true);
        PlayerController.anim.SetBool("up_stand", true);
        PlayerController.anim.SetBool("up", false);
        PlayerController.anim.SetBool("down", false);
        PlayerController.anim.SetBool("run", false);
        PlayerController.anim.SetBool("left_stand", true);
    }
    //静止
    public void Release()
    { 
        PlayerController.isMove = true;
    }
}
