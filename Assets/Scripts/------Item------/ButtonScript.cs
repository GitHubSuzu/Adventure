using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    private RectTransform women;
    private RectTransform men;
    public float x, y, z;
    private int Count = 0;

    [SerializeField] private AudioSource d1;
    [SerializeField] private AudioClip c1;

    // Start is called before the first frame update
    void Start()
    {
        //ImageのRectTransform(Transform)を取得
        women = GameObject.Find("Women").GetComponent<RectTransform>();
        men = GameObject.Find("Men").GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RightImageMove()
    {
        //Countが1以下だったら...
        if (Count < 1)
        {
            //右に800移動(画像一枚分)
            women.localPosition += new Vector3(-800, y, z);
            men.localPosition += new Vector3(-800, y, z);
        }
        else if (Count == 1)//Countが1だったら(次の画像がない)...
        {
            SceneManager.LoadScene("StoryScene");
        }
        Count++;
    }

    public void LeftImageMove()
    {
        //左に800移動(画像一枚分)
        women.localPosition += new Vector3(800, y, z);
        men.localPosition += new Vector3(800, y, z);
        Count--;
    }

    public void Page()
    {
        d1.PlayOneShot(c1);
    }
}
