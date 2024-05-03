using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    [SerializeField] float timeWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // cube (object) will know how much time elapsed
//        Debug.Log(Time.time);
        if (Time.time > timeWait)
        {
            Debug.Log("3 seconds has elapsed");
        }
    }
}