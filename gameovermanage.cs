using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameovermanage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
