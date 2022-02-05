using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarMover : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float gravityMultiplier;

    [SerializeField] private float boostRate;

    private float speedRate;
    private float originalRate;
    private Rigidbody rb;
    private bool isDrifting;
    [SerializeField] private float DriftRate;
    private bool isDriving;
    private Vector3 distance;
    public TextMeshProUGUI distanceText;
    private Vector3 distanceM;
    
    private Quaternion originalRot;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalRate = boostRate;
        speedRate = boostRate * 2;

        originalRot = transform.rotation;
        
        
        UpdateCar();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Accelerate();
        Turn();
        Fall();
    }

    private void Update()
    {
        boostRate = Input.GetButton("Fire1") ? speedRate : originalRate;

        isDrifting = Input.GetKey(KeyCode.Mouse1);

       distance = distance + rb.velocity * Time.deltaTime;

       distanceM = distance;

       Mathf.Abs(distanceM.magnitude);

       distanceText.text = distanceM.magnitude.ToString();
    }

    void Accelerate ()
    {
        if (Input.GetKey(KeyCode.W))
        {
           
            Vector3 forceToAdd = transform.forward;
            forceToAdd.y = 0;
            rb.AddForce(forceToAdd * speed * 10 * boostRate);
        }
        else if (Input.GetKey(KeyCode.S))
        {
          
            Vector3 forceToAdd = -transform.forward;
            forceToAdd.y = 0;
            rb.AddForce(forceToAdd * speed * 10 * boostRate);
        }

        Vector3 locVel = transform.InverseTransformDirection(rb.velocity);
        locVel = new Vector3(0, locVel.y, locVel.z);
        rb.velocity = new Vector3(transform.TransformDirection(locVel).x, rb.velocity.y, transform.TransformDirection(locVel).z);
    }

    void Turn ()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-Vector3.up * turnSpeed * 10 * boostRate);

            if (isDrifting)
            {
                rb.AddForce(-Vector3.up * turnSpeed * DriftRate * boostRate);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(Vector3.up * turnSpeed * 10 * boostRate);
            
            if (isDrifting)
            {
                rb.AddForce(Vector3.up * turnSpeed * DriftRate * boostRate);
            }
        }
    }

    void Fall()
    {
        rb.AddForce(Vector3.down * gravityMultiplier * 10);
    }
    
    private void UpdateCar()
    {
        if ((gameObject.transform.rotation.eulerAngles.z > -450 && gameObject.transform.rotation.eulerAngles.z != 0))
        {
            gameObject.transform.rotation = originalRot;
        }
    }
    
}
