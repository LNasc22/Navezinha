﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAsteroid : MonoBehaviour
{
    public AudioSource explosion;
    // Start is called before the first frame update
    void Start()
    {
        explosion = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
