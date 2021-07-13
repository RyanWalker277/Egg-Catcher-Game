using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instantiation : MonoBehaviour
{
    public GameObject egg;
    public GameObject Canvas;
    public GameObject Bomb;
    public GameObject spawnEgg;
    public GameObject spawnBomb;
    public GameObject orange;
    public GameObject spawnorange;
    public float end = 85.0f;
    public float storetime;
    // Start is called before the first frame update

    void Start()
    {
        storetime = Time.time;
        end = 85.0f;
    }

    // Update is called once per frame
    void Update()
    {     
        if (Time.time >= storetime && end > 0)
        { 
            storetime += 3;     //after every 3 second game object instantiate
            end -= 3;
            spawnEgg = Instantiate(egg, transform.position, Quaternion.identity);
            spawnEgg.transform.SetParent(Canvas.transform);
            transform.position = new Vector3(Random.Range(0.0f, Screen.width), Screen.height, 0);
            spawnBomb = Instantiate(Bomb, transform.position, Quaternion.identity);
            spawnBomb.transform.SetParent(Canvas.transform);
            transform.position = new Vector3(Random.Range(0.0f, Screen.width), Screen.height, 0);
            spawnorange = Instantiate(orange, transform.position, Quaternion.identity);
            spawnorange.transform.SetParent(Canvas.transform);
            transform.position = new Vector3(Random.Range(0.0f, Screen.width), Screen.height, 0);
        }
    }
}

