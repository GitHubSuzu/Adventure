using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //Sub------
    private GameObject six_Camera;  //6サイズのカメラ
    private GameObject corridorCamera;  //廊下のカメラ
    private GameObject centerCamera;  //踊り場のカメラ
    public static GameObject nine_Camera;  //9サイズのカメラ
    private GameObject toiletCamera;  //トイレのカメラ
    //Main------
    public static GameObject roadCamera;  //道(Main)のカメラ

    private GameObject roadWall;
    // Start is called before the first frame update
    void Start()
    {
        //カメラを取得
        six_Camera = GameObject.Find("ElevatorCamera"); 
        corridorCamera = GameObject.Find("CorridorCamera");
        centerCamera = GameObject.Find("CenterCamera");
        nine_Camera = GameObject.Find("ClassCamera");
        toiletCamera = GameObject.Find("Toilet_Camera");
        roadCamera = GameObject.Find("RoadCamera");

        roadWall = GameObject.Find("RoadWall");

        //サブカメラを非アクティブにする
        six_Camera.SetActive(false);
        corridorCamera.SetActive(false);
        centerCamera.SetActive(false);
        nine_Camera.SetActive(false);
        toiletCamera.SetActive(false);
    }

    void Update()
    {

    }

    //校庭にカメラを移動
    public void Rood_up()
    {
        nine_Camera.SetActive(true);
        nine_Camera.transform.position = new Vector3(-25, -40, -10);
        roadCamera.SetActive(false);
        six_Camera.SetActive(false);
    }

    //昇降口にカメラを移動
    public void Front_up()
    {
        roadWall.SetActive(false);
        six_Camera.SetActive(true);
        six_Camera.transform.position = new Vector3(-25, -23, -10);
        roadCamera.SetActive(false);
    }

    //廊下のカメラをアクティブ
    public void Elevator_Up()
    {
        corridorCamera.SetActive(true);
        roadCamera.SetActive(false);
        nine_Camera.SetActive(false);
        six_Camera.SetActive(false);
        toiletCamera.SetActive(false);
    }

    public void Corridor_Up(int No)
    {
        roadCamera.SetActive(false);
        //引数にセットされた数字によって「カメラ」を移動
        switch (No)
        {
            case 1:
                //左の教室
                nine_Camera.SetActive(true);
                nine_Camera.transform.position = new Vector3(-50, 34, -10);
                break;
            case 2:
                //理科室
                nine_Camera.SetActive(true);
                nine_Camera.transform.position = new Vector3(0, 34, -10);
                break;
            case 3:
                //保健室
                six_Camera.SetActive(true);
                six_Camera.transform.position = new Vector3(-25, 57, -10);
                break;
            case 4:
                //踊り場
                centerCamera.SetActive(true);
                corridorCamera.SetActive(false);
                break;
        }
    }

    public void Corridor_Down(int No)
    {
        roadCamera.SetActive(false);
        //引数にセットされた数字によって...
        switch (No)
        {
            case 1:
                //右の教室
                nine_Camera.SetActive(true);
                nine_Camera.transform.position = new Vector3(0, 0, -10);
                break;
            case 2:
                //職員室
                nine_Camera.SetActive(true);
                nine_Camera.transform.position = new Vector3(-50, 0, -10);
                break;
            case 3:
                // //踊り場
                centerCamera.SetActive(true);
                corridorCamera.SetActive(false);
                break;
        }
    }

    public void Toilet(int No)
    {
        roadCamera.SetActive(false);
        //引数にセットされた数字によって...
        switch (No)
        {
            case 1:
                //女子トイレ
                toiletCamera.SetActive(true);
                toiletCamera.transform.position = new Vector3(-77, 16.5f, -10);
                break;
            case 2:
                //男子トイレ
                toiletCamera.SetActive(true);
                toiletCamera.transform.position = new Vector3(27, 16.5f, -10);
                break;
        }
    }
}
