using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishGameButton : MonoBehaviour
{
    private bool switchOnePress;
    public static bool finishButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        finishButtonPressed = false;
        switchOnePress = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void finishButtonPressed2()
    {
        if (!switchOnePress)
        {
            switchOnePress = true;
            finishButtonPressed = true;
        }
    }

}
