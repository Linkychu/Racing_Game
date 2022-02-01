using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.InputSystem;
using TMPro;
public class playerMove : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float speed;

    [SerializeField] private Transform centerOfMass;
    public float distance;

    public float distanceD;

    public GameObject TextObj;

    private float x;
    private float z;

    private TextMeshProUGUI _textMeshProUGUI;

     [SerializeField] private WheelCollider WheelCollider1;
     [SerializeField] private WheelCollider WheelCollider2;
     [SerializeField] private WheelCollider WheelCollider3;
     [SerializeField] private WheelCollider WheelCollider4;
     
     [SerializeField] private Transform Wheel1;
     [SerializeField] private Transform Wheel2;
     [SerializeField] private Transform Wheel3;
     [SerializeField] private Transform Wheel4;
     

  [SerializeField] protected float motorForce;

  [SerializeField] private float breakForce;

  [SerializeField] private float maxSteeringAngle;
  private float steeringAngle;
  private float boostMotorForce;
  private float originalMotorForce;
  

  private float currentbreakForce;
  private bool isBreaking;
  
  [SerializeField]private float boostRate = 6;
  
  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _textMeshProUGUI = TextObj.GetComponent<TextMeshProUGUI>();
        originalMotorForce = motorForce;
        boostMotorForce = motorForce * boostRate;

        rb.centerOfMass = centerOfMass.localPosition;
    }

    void Update()
    {
        motorForce = Input.GetButton("Fire1") ? boostMotorForce : originalMotorForce;
    }
    private void FixedUpdate()
    {
       
        UserInput();
        WheelStuff();
        HandlePhysics();
        WheelUpdate();
    }
    
    private void UserInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

       // Vector3 MoveDir = x * transform.right + z * transform.forward;
        
        //rb.AddForce(MoveDir.normalized * speed);

      //  isBreaking = Input.GetKey(KeyCode.Space);

      if (x == 0 && z == 0)
      {
          isBreaking = true;
      }

      else
      {
          isBreaking = false;
      }
       

        distance = (speed * Time.deltaTime * z) + (speed * Time.deltaTime * x) + distance;

        distanceD = Mathf.Abs(distance);
        Math.Round(distanceD, 2);

        _textMeshProUGUI.text = distanceD.ToString();
    }

  
    private void WheelStuff()
    {
        WheelCollider1.motorTorque = z * motorForce;
        WheelCollider2.motorTorque = z * motorForce;
        
        currentbreakForce = isBreaking ? breakForce : 0f;
        Broken();
    }

    private void Broken()
    {
        WheelCollider1.brakeTorque = currentbreakForce;
        WheelCollider2.brakeTorque = currentbreakForce;
        WheelCollider3.brakeTorque = currentbreakForce;
        WheelCollider4.brakeTorque = currentbreakForce;
    }

    private void HandlePhysics()
    {
        steeringAngle = x * maxSteeringAngle;
        WheelCollider1.steerAngle = steeringAngle;
        WheelCollider2.steerAngle = steeringAngle;
    }

    private void WheelUpdate()
    {
        UpdateWheel(WheelCollider1, Wheel1);
        UpdateWheel(WheelCollider2, Wheel2);
        UpdateWheel(WheelCollider3, Wheel3);
        UpdateWheel(WheelCollider4, Wheel4);
    }

    private void UpdateWheel(WheelCollider wheelCollider, Transform wheel)
    {
        Vector3 pos;
        Quaternion rotation;
        wheelCollider.GetWorldPose(out pos, out rotation);
        wheel.rotation = rotation;
        wheel.position = pos;
    }

 
    // Update is called once per frame
  
}
