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

    public float distance;

    public float distanceD;

    public GameObject TextObj;

    private TextMeshProUGUI _textMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _textMeshProUGUI = TextObj.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 MoveDir = x * transform.right + z * transform.forward;
        
        rb.AddForce(MoveDir.normalized * speed);
        
       

        distance = (speed * Time.deltaTime * z) + (speed * Time.deltaTime * x) + distance;

        distanceD = Mathf.Abs(distance);
          Math.Round(distanceD, 2);

        _textMeshProUGUI.text = distanceD.ToString();

    }
}
