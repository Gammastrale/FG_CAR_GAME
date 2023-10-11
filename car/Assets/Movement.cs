using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    private NewControls newControls;
    Rigidbody m_Rigidbody;
    public GameObject spawn;
    int points;
    GameObject retry;

    private void Awake()
    {
        newControls = new NewControls();
    }

    private void OnEnable()
    {
        newControls.Enable();
    }

    private void OnDisable()
    {
        newControls.Disable();
    }


    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        retry = GameObject.Find("Canvas(Clone)/Retry");
        retry.SetActive(false);
    }


    public void Up(InputAction.CallbackContext ctx)
    {
        if (Time.timeScale == 1)
        {
            m_Rigidbody.AddForce(transform.forward * 125);
        }


    }

    public void Down(InputAction.CallbackContext ctx)
    {
        if (Time.timeScale == 1)
        {
            m_Rigidbody.AddForce(transform.forward * -125);
        }
    }

    public void Right(InputAction.CallbackContext ctx)
    {

        if (Time.timeScale == 1)
        {
            gameObject.transform.localRotation *= Quaternion.Euler(0, 15, 0);
        }
    }

    public void Left(InputAction.CallbackContext ctx)
    {
        if (Time.timeScale == 1)
        {
            gameObject.transform.localRotation *= Quaternion.Euler(0, -15, 0);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CheckPoint")
        {
            spawn = other.gameObject;
            points += 1;
            if (other.name == "FinishLine" && points > 14)
            {
                
                Time.timeScale = 0;
                retry.SetActive(true);
            }
        }

        if (other.tag == "Falling")
        {
            gameObject.transform.position = spawn.transform.position;
        }


    }

}
