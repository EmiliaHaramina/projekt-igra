using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ContinueGame()
    {
        GameObject.FindGameObjectWithTag("closingPanel").GetComponent<Animator>().Play("ClosePanelMenu", -1, 0f);
        Invoke("LaterChangeSceneContinue", 2f);
    }

    public void LaterChangeSceneContinue()
    {
        SceneManager.LoadScene("Main");
    }
}
