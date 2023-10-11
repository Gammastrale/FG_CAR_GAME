using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    GameObject menu;
    public GameObject canvas;
    public GameObject eventSys;
    bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(canvas);
        Instantiate(eventSys);
        menu = GameObject.Find("Canvas(Clone)/Continue");
        menu.SetActive(false);
    }

    public void Pausing(InputAction.CallbackContext ctx)
    {

        if (isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
            menu.SetActive(true);

        }
        else
        {
            Time.timeScale = 1;
            isPaused = false;
            menu.SetActive(false);

        }

        // M button
    }

    public void PausingButton()
    {
        Time.timeScale = 1;
        isPaused = false;

        // UI Button
    }

    public void QuitButton()
    {
        
        Application.Quit();
    }

    public void Reset()
    {
        Addressables.LoadSceneAsync("StartingScreen");
    }
}
