using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EggScorePrint : MonoBehaviour
{
    public GameObject gameview;
    public float storetime;
    public Image healthBar;
    float health, maxhealth = 100;
    float lerpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        storetime = Time.time;
        health = maxhealth;
    }
    private int score = 0;
    public Text Scoreprint;
    public Text result;
    public Text printtime;
    public Text result1;
    public Text waiting;
    public Text waiting_time;
    public Text message;
    public float endtime = 90.0f;
    public float time2 = 5.0f;
    public string str;     // these are for printing result of game at runtime
    public string str1;
    public string str2;
    public GameObject GameOver;
    public void game_over()
    {
        gameview.SetActive(false);
        GameOver.SetActive(true);
    }
    public void OnTriggerEnter2D(Collider2D other)
    { if (other.gameObject.tag == "Egg" && endtime>0)
        {
            Destroy(other.gameObject);
             score += 2;
        }
        
       if (other.gameObject.tag == "orange" && endtime > 0)
       {
            Destroy(other.gameObject);
             score += 1;
       }  
      if(other.gameObject.tag == "bomb" && endtime>0)
      {
            Destroy(other.gameObject);
            health -= 25;
      }
    }
    // Update is called once per frame
    void Update()
    {    
         Scoreprint.text = score.ToString();
        lerpSpeed = 3f * Time.deltaTime;
        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, (health / maxhealth),lerpSpeed);
        Color healthColor = Color.Lerp(Color.red, Color.green, (health / maxhealth));
        healthBar.color = healthColor;
        // Debug.Log(score);
        if (Time.time > storetime && endtime > 0)   //time1 = 1 (timer will run 1 s to 150 s)
        {
            storetime += 1;
            endtime -= 1;
            printtime.text = endtime.ToString();
        }
            if (time2 > 0)
            {
                if (Time.time > storetime && endtime <= 0)                              //all printing condition constrain                                                                                 
                {
                    storetime += 1;
                    time2 -= 1;//waiting time decreases
                    if (score >= 25)
                    {
                        str = "Congratulations! YOU WON";
                        result.text = str.ToString();
                    }
                    else
                    {
                        str = "Sorry! YOU LOSE";
                        result1.text = str.ToString();
                    }
                    str1 = "Please wait    seconds";
                    str2 = " time up !now basket willn't collect any of items";     //prints message
                    waiting.text = str1.ToString();
                    waiting_time.text = time2.ToString(); //prints time to wait 
                    message.text = str2.ToString();
                }
            }      
            if (time2 == 0 || health==0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
    }
}
