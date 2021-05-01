using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Choice : MonoBehaviour
{
    public GameObject textBox;

    public GameObject Choice1;

    public GameObject Choice2;

    public int Gamestat = 0;

    public GameObject[] Scenes;

    public void Choice_1()
    {
        if (Gamestat == 0)
        {
            Gamestat = 1;
        }
    }
    public void Choice_2()
    {
        if (Gamestat == 0)
        {
            Gamestat = 2;
        }
    }


    public void Update()
    {

        for (int i = 0; i < Scenes.Length; i++)
        {

            if (Gamestat == i)
            {
                Scenes[i].SetActive(true);
            }
            else if (Gamestat != i)
            {
                Scenes[i].SetActive(false);
            }
           
        }


    }

}
