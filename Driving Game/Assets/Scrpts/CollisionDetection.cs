using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public LayerMask lapMask;

    public Vector3 lastLapPos;

    public LayerMask OutOfBoundsMask;

    private Transform player;

    private CarMover _carMover;

    public bool touching;
    
    

    [SerializeField] private LayerMask acceptableLayer;
    
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponentInParent<Transform>();

        _carMover = gameObject.GetComponentInParent<CarMover>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Physics.Raycast(transform.position, Vector3.down) == false)
        {
          
                Debug.Log("Bs");
              
        }*/
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Triggered");
        
        Debug.Log(other.gameObject.layer);
        if (other.gameObject.layer == 9)
        {
            Debug.Log("yes");
            StartCoroutine(_carMover.OutOfBounds());
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        /*if (_carMover.isGrounded)
        {
            StartCoroutine(_carMover.flipped()); 
        }*/
    }


   
}
