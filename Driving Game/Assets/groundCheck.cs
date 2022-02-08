using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    private CarMover CarScript;

    [SerializeField] private GameObject car;
    
    
    // Start is called before the first frame update
    void Start()
    {
        CarScript = car.GetComponent<CarMover>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            Debug.Log("yes");
            CarScript.isGrounded = true;
        }
        
        Debug.Log("Layer " + other.gameObject.layer);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            Debug.Log("no");
            
            CarScript.isGrounded = false;
        }
        
        Debug.Log("Left Layer " + other.gameObject.layer);
    }
}
