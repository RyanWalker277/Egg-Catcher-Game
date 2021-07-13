using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEgg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Egg")
        {
            Destroy(other.gameObject);
            
        }
        if (other.gameObject.tag == "bomb")
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
}
