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
    [SerializeField]private bool isDrifting;
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


    [SerializeField] private KeyCode driftKey;

    private carDisabler _carDisabler;

    [SerializeField] private GameObject blackOut;

    private CollisionDetection _collisionDetection;

    private bool ableToDrive;

    [SerializeField] private Transform groundCheck;

    private CarController _carController;

    private float ratioSpeed;

    private float RegularSpeed;

    public bool Truck;
    // Start is called before the first frame update

    protected void Awake()
    {
        _carController = new CarController();
    }

    protected void OnEnable()
    {
        _carController.Car.Enable();
    }

    protected void OnDisable()
    {
        _carController.Car.Disable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalRate = boostRate;
        speedRate = boostRate * 2;

        originalRot = transform.rotation;

        _carDisabler = GetComponent<carDisabler>();
        //UpdateCar();

        ableToDrive = true;

        ratioSpeed = speed / DriftRate;

        RegularSpeed = speed;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
//        Debug.Log(speed);
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

        isDrifting = Input.GetKey(driftKey) || Input.GetKey(KeyCode.Mouse1);
        

       distance = distance + rb.velocity * Time.deltaTime;

       distanceM = distance;

       Mathf.Abs(distanceM.magnitude);

       distanceText.text = distanceM.magnitude.ToString();


       if (Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.Joystick1Button4))
       {
           StartCoroutine(flipped());
       }
 
       
 
    }

    void Accelerate ()
    {
        speed = isDrifting ? ratioSpeed : RegularSpeed;
        
       // Debug.Log(speed);
        
        float v = Input.GetAxis("Vertical");
       
     
        
        if (Input.GetKey(KeyCode.W) || v > 0 )
        {

            Vector3 forceToAdd = transform.forward;
            forceToAdd.y = 0;
            rb.AddForce(forceToAdd * speed * 10 * boostRate);
        }
        
        else if (Input.GetKey(KeyCode.S) || v < 0)
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
        float h = Input.GetAxis("Horizontal");
        
        if (Input.GetKey(KeyCode.A) || h < 0)
        {
           rb.AddTorque(-Vector3.up * turnSpeed * 10 * boostRate);

            if (isDrifting)
           {
               rb.AddForce(-Vector3.up * turnSpeed * DriftRate * boostRate);
              
           }
           
        }
        
        else if (Input.GetKey(KeyCode.D) || h > 0)
        {
           rb.AddTorque(Vector3.up  * turnSpeed * 10 * boostRate);
            
            if (isDrifting)
            {
                
                rb.AddForce(Vector3.up * h * turnSpeed *DriftRate);
            }
        }
    }

    void Fall()
    {
        rb.AddForce(Vector3.down * gravityMultiplier * 10);
    }

    void Jump()
    {

        if (!Truck)
        {
            isGrounded = Physics.CheckSphere(groundCheck.transform.position, 1, TrackLayer);
        }

        else
        {
            isGrounded = Physics.CheckSphere(groundCheck.transform.position, 1, TrackLayer);
        }

        if (Input.GetButton("Jump"))
        {
            if (isGrounded)
            {
                if (!Truck)
                {
                    rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
                }

                else
                {
                    rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
                }
                
            }
        }
    }
    
   public IEnumerator flipped()
    {
        yield return new WaitForSeconds(1);
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
