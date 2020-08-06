using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailRewind : MonoBehaviour
{
    // Start is called before the first frame update
    public TrailRenderer line;

    public float attackRate = 1f;
    float nextAttackTime = 0f;

    public float timeRemaining = 2;
    bool rewindCountdown = false;
    public float cooldown = 4;
    bool isCooldown = false;


    void Start()
    {
        line = gameObject.GetComponent<TrailRenderer>();
        line.enabled = false;
    }
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Alpha2) && rewindCountdown == false
            && isCooldown == false)
        {
            rewindCountdown = true;
            line.enabled = true;
            isCooldown = true;

        }

        if (rewindCountdown == true)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
        }

        if (timeRemaining < 0)
        {
            rewindCountdown = false;
            line.enabled = false;
            timeRemaining = 2;
        }

        if (isCooldown == true)
        {
            cooldown -= Time.deltaTime;
        }

        if (cooldown < 0)
        {
            isCooldown = false;
        }
    }
}
