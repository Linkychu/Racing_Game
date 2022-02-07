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
    public bool isGrounded;
    [SerializeField] private float jumpForce = 10;
    private Quaternion originalRot;
    [SerializeField] private LayerMask TrackLayer;
    [SerializeField] private LayerMask OutOfBoundsLayer;

  

    private carDisabler _carDisabler;

    [SerializeField] private GameObject blackOut;

    private CollisionDetection _collisionDetection;

    private bool ableToDrive;

    [SerializeField] private Transform groundCheck;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalRate = boostRate;
        speedRate = boostRate * 2;

        originalRot = transform.rotation;

        _carDisabler = GetComponent<carDisabler>();
        //UpdateCar();

        ableToDrive = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ableToDrive)
        {
            //UpdateCar();
            Accelerate();
            Turn();
            Jump();
        }
        
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

    void Jump()
    {

        isGrounded = Physics.CheckSphere(transform.position, 1.1f, TrackLayer);

        if (Input.GetButton("Jump"))
        {
            if (isGrounded)
            {
                rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            }
        }
    }
    
   public IEnumerator flipped()
    {
        yield return new WaitForSeconds(5);
        gameObject.transform.rotation = originalRot;
    }

   public IEnumerator OutOfBounds()
    {
        ableToDrive = false;
        yield return new WaitForSeconds(2);
        blackOut.SetActive(true);
        gameObject.transform.position = LapCount.Instance.lastLapPos;
        gameObject.transform.rotation = originalRot;
        yield return new WaitForSeconds(2);
        blackOut.SetActive(false);
        yield return new WaitForSeconds(4);
        ableToDrive = true;

    }

  
}
