﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AD3 : MonoBehaviour
{
    private float delay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
    }

    // Update is called once per frame
    void Update()
    {

    }
}