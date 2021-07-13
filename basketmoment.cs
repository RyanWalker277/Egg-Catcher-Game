using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketmoment : MonoBehaviour
{
    public GameObject bucket;
    private Vector2 pos;
    private Vector3 oldPos;
    // Start is called before the first frame update
    void Start()
    {
        oldPos = bucket.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                Vector3 pos1 = new Vector3(pos.x, oldPos.y, 0);
                bucket.transform.position = pos1;
            }
        }
    }
}