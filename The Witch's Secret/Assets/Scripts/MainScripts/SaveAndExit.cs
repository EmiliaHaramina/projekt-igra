using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveAndExit : MonoBehaviour
{
    public static bool anyButtonPressed;
    public static bool saveExitButtonPressed;
    // Start is called before the first frame update
    void Start()
    {
        saveExitButtonPressed = false;
        anyButtonPressed = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void noButtonPressed()
    {
        if (!anyButtonPressed)
        {
            GameObject.FindGameObjectWithTag("mainCanvas").gameObject.transform.GetChild(2).gameObject.SetActive(true);
            ActivatePauseMenu.pauseGameOnce = false;
            GameObject.Find("PauseMenu").transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("PauseMenu").transform.GetChild(1).gameObject.SetActive(false);
        }
    }

    public void yesButtonPressed()
    {
        if (!anyButtonPressed)
        {
            anyButtonPressed = true;
            saveExitButtonPressed = true;
            GameObject.Find("PauseMenu").gameObject.transform.GetChild(2).gameObject.SetActive(true);
            Invoke("changeToMenu", 1.5f);

        }
    }

    public void changeToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
