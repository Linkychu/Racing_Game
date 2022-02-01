using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carDisabler : MonoBehaviour
{
    private CarMover _carMover;
    // Start is called before the first frame update

    private void Awake()
    {
       _carMover = GetComponent<CarMover>();
       _carMover.enabled = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.TimerScript.Started)
        {
            _carMover.enabled = true;
        }
    }
}
