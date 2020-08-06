using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using UnityEngine;

public class Rewind : MonoBehaviour
{
    //public Transform rewindPoint;
    //public Transform player;
    public float timeRemaining = 5;
    bool rewindCountdown = false;
    //public ImageFileMachine imageCooldown
    bool rewind = false;
    private Vector3 rewindPosition;
    // Update is called once per frame

    public float cooldown = 0;
    bool isCooldown = false;

    public GameObject rewindLocation;

    void Start()
    {
        
    }
    void Update()
    {
        //Debug.Log(playerT.position);

        if (Input.GetKeyDown(KeyCode.Alpha2) && rewindCountdown == false
            && isCooldown == false)
        {
            rewindCountdown = true;
            rewindPosition = transform.position;
            //Debug.Log(transform.position);
            isCooldown = true;
            Instantiate(rewindLocation, transform.position,Quaternion.identity);


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
            timeRemaining = 5;
        }

        if(isCooldown == true)
        {
            cooldown -= Time.deltaTime;
        }

        if (cooldown < 0)
        {
            isCooldown = false;
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
