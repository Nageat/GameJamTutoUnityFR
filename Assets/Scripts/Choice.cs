using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Choice : MonoBehaviour
{
    public GameObject textBox;

    public string Choice1Scene;
    public GameObject Choice1;

    public string Choice2Scene;
    public GameObject Choice2;

    public string Choice3Scene;
    public GameObject Choice3;

    public int choiceMade = 0; 

    public void Choice_1()
    {
        SceneManager.LoadScene("Choice1Scene", LoadSceneMode.Additive);
    }
    public void Choice_2()
    {
        SceneManager.LoadScene("Choice2Scene", LoadSceneMode.Additive);
    }
    public void Choice_3()
    {
        SceneManager.LoadScene("Choice3Scene", LoadSceneMode.Additive);
    }

}
