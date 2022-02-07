using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lap : MonoBehaviour
{
    private bool Loaded;

    public int LapId;


    private int LapProof;

    public bool isFlag;

   
   // public Transform lapHead;
    // Start is called before the first frame update
    void Start()
    {
        LapCount.Instance.LapIntCheck = 0;
        LapId = transform.GetSiblingIndex();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFlag)
        {
            if (gameObject.GetComponent<Renderer>().isVisible)
            {
                Loaded = true;
            }
        }
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("entered");
            LapCount.Instance.lastLapPos = gameObject.transform.position + new Vector3(0, 2, 0);
            LapCount.Instance.lastPlayerRot = other.gameObject.transform.rotation;
            int lapCheck = LapCount.Instance.LapIntCheck;
            
            if(lapCheck == LapId)
            {
                LapCount.Instance.LapBox();
            }
        }
        
        
    }
}
