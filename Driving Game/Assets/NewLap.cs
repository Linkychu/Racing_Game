using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (LapCount.Instance.LapIntCheck >= 0.95 * LapCount.Instance.TotalLapCheck )
            {
                LapCount.Instance.LapFinish();
            }
        }
    }
}
