using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseScript : MonoBehaviour
{
   
    AudioSource DoorSound;

    void Start()
    { 
        DoorSound = GetComponent<AudioSource>();
    }

    void Update()
    {
      
    }

    public void Teleport_up()
    {
        //引数にセットされた数字が0より大きかったらSEを流す
        if (PlayerController.Change > 0)
        {
            DoorSound.PlayOneShot(DoorSound.clip);
        }
        //Playerのpositionを取得
        Vector3 Player = GameObject.Find("Player").transform.position;
        //plyerの位置をy座標を上に9.5
        GameObject.Find("Player").transform.position = new Vector3(Player.x, Player.y + 9.5f, Player.z);
    }

    public void Teleport_down()
    {
        //引数にセットされた数字が0より大きかったらSEを流す
        if (PlayerController.Change > 0)
        {
            DoorSound.PlayOneShot(DoorSound.clip);
        }
        //Playerのpositionを取得
        Vector3 Player = GameObject.Find("Player").transform.position;
        //plyerの位置をy座標を下に9.5
        GameObject.Find("Player").transform.position = new Vector3(Player.x, Player.y - 9.5f, Player.z);
    }

    public void Teleport_Left()
    {
        //Playerのpositionを取得
        Vector3 Player = GameObject.Find("Player").transform.position;
        //plyerの位置をx座標を左に9.5
        GameObject.Find("Player").transform.position = new Vector3(Player.x - 9.0f, Player.y, Player.z);
    }

    public void Teleport_Right()
    {
        //Playerのpositionを取得
        Vector3 Player = GameObject.Find("Player").transform.position;
        //plyerの位置をx座標を右に9.5
        GameObject.Find("Player").transform.position = new Vector3(Player.x + 9.0f, Player.y, Player.z);
    }

    public void Up_Ivent()
    {
        Vector3 Player = GameObject.Find("Player").transform.position;
        GameObject.Find("Player").transform.position = new Vector3(Player.x, Player.y + 9.5f, Player.z);
        //Playerの動きを非アクティブ
        PlayerController.isMove = false;
        //PlayerController.isMove_Item = false;
    }
}
