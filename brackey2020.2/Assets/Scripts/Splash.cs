using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{
    // Start is called before the first frame update
    public TrailRenderer line;

    public float attackRate = 1f;
    float nextAttackTime = 0f;
    void Start()
    {
        line = gameObject.GetComponent<TrailRenderer>();
        line.enabled = false;
    }
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                line.enabled = true;

                nextAttackTime = Time.time + 1f / attackRate;
            }
            else
            {
                line.enabled = false;
            }
        }

    }
}
