using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainScene1()
    {
        Invoke("MainScene", 1);
    }

    void MainScene()
    {
        //Saveデータがあったら...
        if (SaveLoad.Count > 0)
        {
            SceneManager.LoadScene("MainScene");
        } 
    }

    public void IntroductionScene1()
    {
        Invoke("IntroductionScene", 1);
    }

    void IntroductionScene()
    {
        SceneManager.LoadScene("IntroductionScene");
    }

    public void TitleScene1()
    {
        Invoke("TitleScene", 1);
    }

    public void TitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void ResultScene()
    {
        SceneManager.LoadScene("ResultScene");
    }

    public void Operation1()
    {
        Invoke("Operation", 1);
    }

    public void Operation()
    {
        SceneManager.LoadScene("OperationScene");
    }
}
