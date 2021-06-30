using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Load_Text : MonoBehaviour
{

    public GameObject image;
  
    void Start()
    {
        //Imageを取得して非アクティブ
        image = GameObject.Find("Image");
        image.SetActive(false);
    }

    public void Click()
    {
        //セーブデータがなかったら...
        if (SaveLoad.Count == 0)
        {
            image.SetActive(true);
            Invoke("Destroy", 1);
        }
    }

    public void Destroy()
    {
        image.SetActive(false);
    }
}