using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rewindPoint : MonoBehaviour
{
    float lifetime = 5.0f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {


    }
}
