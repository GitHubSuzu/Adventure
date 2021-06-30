using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public float x, y, z;

    //SaveDataの管理変数
    public static int Count { private set; get; } = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Save()
    {
        //Playerのpositionを PlayerPrefsにセット
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
        PlayerPrefs.Save();
        Count++;
    }

    public void Load()
    {
        // PlayerPrefsにセットされたPlayerのpositionを取得
        PlayerPrefs.GetFloat("x", x);
        PlayerPrefs.GetFloat("y", y);
        PlayerPrefs.GetFloat("z", z);

        Vector3 LoadPosition = new Vector3(x, y, z);
        transform.position = LoadPosition;
    }
}
