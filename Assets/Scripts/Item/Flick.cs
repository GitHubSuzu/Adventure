using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flick : MonoBehaviour
{
    public static GameObject TileA;
    int point = 0;
    public GameObject messageText;
    // Use this for initialization
    void Start()
    {
        TileA = GameObject.Find("TileA");
    }

    // Update is called once per frame

    private Vector3 touchStartPos;
    private Vector3 touchEndPos;

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            touchStartPos = new Vector3(Input.mousePosition.x,
                                        Input.mousePosition.y,
                                        Input.mousePosition.z);
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            touchEndPos = new Vector3(Input.mousePosition.x,
                                      Input.mousePosition.y,
                                      Input.mousePosition.z);
            GetDirection();
        }
    }

    void GetDirection()
    {
        float directionX = touchEndPos.x - touchStartPos.x;
        float directionY = touchEndPos.y - touchStartPos.y;
        string Direction = null;

        if (Mathf.Abs(directionY) < Mathf.Abs(directionX))
        {
            if (30 < directionX)
            {
                //右向きにフリック
                Direction = "right";
            }
            else if (-30 > directionX)
            {
                //左向きにフリック
                Direction = "left";
            }
        }
        else if (Mathf.Abs(directionX) < Mathf.Abs(directionY))
        {
            if (30 < directionY)
            {
                //上向きにフリック
                Direction = "up";
            }
            else if (-30 > directionY)
            {
                //下向きのフリック
                Direction = "down";
            }
        }
        else
        {
            //タッチを検出
            Direction = "touch";
        }
        switch (Direction)
        {
            case "up":
                //上フリックされた時の処理
                TileA.transform.position += new Vector3(0, 50, 0);
                point++;
                break;

            case "down":
                //下フリックされた時の処理
                TileA.transform.position += new Vector3(0, -50, 0);
                point--;
                break;

            case "right":
                //右フリックされた時の処理
                TileA.transform.position += new Vector3(50, 0, 0);
                point++;
                break;

            case "left":
                //左フリックされた時の処理
                TileA.transform.position += new Vector3(-50, 0, 0);
                point--;
                break;

            case "touch":
                //タッチされた時の処理
                break;

        }
    }

    public void OnClick()
    {
        if(point == 6)
        {
            messageText.GetComponent<Text>().text = "正解！";
            PlayerController.Count += 1;
        }
    }
}