using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   //player(変数)を宣言
    private GameObject Player;

    void Start()
    {
        //Playerを取得
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        //Playerがnullではなかったら...
        if (Player != null)
        {
            //playerのpositionを取得
            Vector3 PlayerPos = Player.transform.position;

            //カメラとプレイヤーの位置を同じにする
            transform.position = new Vector3(PlayerPos.x, PlayerPos.y, -10);
        }
    }
}
