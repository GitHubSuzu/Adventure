using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class Images : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image Image { get { return GetComponent<Image>(); } }
    public Sprite sprite1;
    public Sprite sprite2;


    // オブジェクトの範囲内にマウスポインタが入った際に呼び出されます。
    // this method called by mouse-pointer enter the object.
    public void OnPointerEnter(PointerEventData eventData)
    {
        // image.color = Color.red;
        Image.sprite = sprite1;
    }

    // オブジェクトの範囲内からマウスポインタが出た際に呼び出されます。
    // 
    public void OnPointerExit(PointerEventData eventData)
    {
        Image.sprite = sprite2;
    }
}
