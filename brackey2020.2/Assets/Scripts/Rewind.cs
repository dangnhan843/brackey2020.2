using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewind : MonoBehaviour
{
    //public Transform rewindPoint;
    //public Transform player;
    public float timeRemaining = 2;
    bool rewindCountdown = false;
    bool rewind = false;
    private Vector3 rewindPosition;
    // Update is called once per frame
    void Start()
    {
        
    }
    void Update()
    {
        //Debug.Log(playerT.position);

        if (Input.GetButtonDown("Fire1") && rewindCountdown == false)
        {
            rewindCountdown = true;
            rewindPosition = transform.position;
            //Debug.Log(transform.position);
        }

        if (rewindCountdown == true)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                Debug.Log(timeRemaining);
            }
        }

        if (timeRemaining < 0)
        {
            rewind = true;
            rewindCountdown = false;
            timeRemaining = 2;
        }

        if (rewind == true)
        {
            rewindChorno();
            Debug.Log("here" + rewind);
        }
        
    }

    public void rewindChorno()
    {
        this.transform.position = rewindPosition;
        rewind = false;

    }
}
