using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenNewGame()
    {
        GameObject.FindGameObjectWithTag("closingPanel").GetComponent<Animator>().Play("ClosePanelMenu", -1, 0f);
        Invoke("LaterChangeScene", 2f);
    }

    public void LaterChangeScene()
    {
        SceneManager.LoadScene("Main");
    }
}
