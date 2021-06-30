using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    private GameObject menu_canvas;
    private GameObject menu_button;
    int menu_count = 0;
    // Start is called before the first frame update
    void Start()
    {
        menu_canvas = GameObject.Find("Canvas_Menu");
        menu_canvas.SetActive(false);
        menu_button = GameObject.Find("Menu_Button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu()
    {
        menu_count++;
        if (menu_count % 2 != 0)
        {
            menu_canvas.SetActive(true);
            menu_button.SetActive(false);
        }
    }
    public void Close()
    {
        menu_count++;
        if (menu_count % 2 == 0)
        {
            menu_canvas.SetActive(false);
            menu_button.SetActive(true);
        }
    }
}
