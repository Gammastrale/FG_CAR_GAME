using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;


public class startMenu : MonoBehaviour
{
    public GameObject mapButton1;
    public GameObject mapButton2;
    public GameObject mapButton3;
    public GameObject Starting;

    public void StartButton()
    {
        mapButton1.SetActive(true);
        mapButton2.SetActive(true);
        mapButton3.SetActive(true);
        Starting.SetActive(false);

    }

    public void LoadMap1()
    {

        Time.timeScale = 1.0f;
        Addressables.LoadSceneAsync("FirstMap");
        
    }

    public void LoadMap2()
    {
        Time.timeScale = 1.0f;
        Addressables.LoadSceneAsync("SecondMap");
        
    }

    public void LoadMap3()
    {
        Time.timeScale = 1.0f;
        Addressables.LoadSceneAsync("ThirdMap");
        
    }

}
