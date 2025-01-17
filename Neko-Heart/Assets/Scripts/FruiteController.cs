﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruiteController : MonoBehaviour
{
    public int score = 0;
    public AudioSource pickupSound;

    // Start is called before the first frame update
    void Start()
    {
        pickupSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<PlayerController>().AddScore(this.score);

        Destroy(this.gameObject);

    }
}
