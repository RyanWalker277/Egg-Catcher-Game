using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamentry : MonoBehaviour
{
    public GameObject gameview;
    public GameObject rulesPanel;
    // Start is called before the first frame update
   private void Start()
    {
        gameview.SetActive(false);
        rulesPanel.SetActive(false);
        Time.timeScale = 0;
    }
    // Update is called once per frame
   public void entergame()
    {
       gameview.SetActive(true);
        Time.timeScale = 1;
    }
    public void exitgame()
    {
        Application.Quit();
    }
    public void ruleGame()
    {
        rulesPanel.SetActive(true);
    }
    public void back()
    {
        rulesPanel.SetActive(false);
    }
} 