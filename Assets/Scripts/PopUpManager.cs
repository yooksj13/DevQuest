using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUpManager : MonoBehaviour
{
    public static PopUpManager instance;

    public GameObject popUp;
    public static bool PopUpOn = false;

    private void Awake()
    {
        popUp.SetActive(false);
    }

    private void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            if (!PopUpOn)
            {
                OnClickExit();
            }
            else
            {
                Application.Quit();
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            if(PopUpOn)
            {
                PopUpOn = false;
                popUp.SetActive(false);

            }
        }
    } 

    public void OnClickExit()
    {
        PopUpOn = true;
        popUp.SetActive(true);
    }

    public void OnClickRestart()
    {
        GameManager.instance.GameScore = 0;
        GameManager.instance.GameTime = 90;
        GameManager.instance.PlayerLife = 100;
        SceneManager.LoadScene("Assignment");
    }
}
