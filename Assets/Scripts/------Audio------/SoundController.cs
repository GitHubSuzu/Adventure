using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource a1;//AudioSource型の変数a1を宣言 使用するAudioSourceコンポーネントをアタッチ必要

    [SerializeField] private AudioClip b1;//AudioClip型の変数b1を宣言 使用するAudioClipをアタッチ必要
    [SerializeField] private AudioClip b2;//AudioClip型の変数b2を宣言 使用するAudioClipをアタッチ必要 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneMove()
    {
        a1.PlayOneShot(b1);
    }

    public void ButtonClick()
    {
        a1.PlayOneShot(b2);
    }
}
