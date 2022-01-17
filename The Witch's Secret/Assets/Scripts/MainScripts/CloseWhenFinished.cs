using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseWhenFinished : MonoBehaviour
{
    private bool closeOnce;
    // Start is called before the first frame update
    void Start()
    {
        closeOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (FinishGameButton.finishButtonPressed == true && !closeOnce)
        {
            closeOnce = true;
            FinishGameButton.finishButtonPressed = false;
            GameObject.Find("FinishGamePanel").gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Invoke("changeLevel", 1.35f);
            Invoke("changeToMenu", 1.5f);
        }
    }

    public void changeToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void changeLevel()
    {
        PlayerPrefs.SetInt("Level", 1);
    }
}
