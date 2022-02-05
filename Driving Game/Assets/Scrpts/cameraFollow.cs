using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;

   private Vector3 offset;

    [SerializeField] private float speed;

    public GameObject car1;

    public GameObject car2;

    public GameObject car3;

    [SerializeField] private Vector3 offset1;
    [SerializeField] private Vector3 offset2;
    [SerializeField] private Vector3 offset3;
    // Start is called before the first frame update

    private void Start()
    {
        /*if (GlobalCarChanger.GlobalCarChangerz.ntscar)
        {
            offset = new Vector3(0.529999971f, 9.22000027f, -19.5499992f);
        }*/
        
        checkForPlayer();
        
    }

    public void checkForPlayer()
    {
        if (car1.activeInHierarchy)
        {
            player = car1.transform;
            offset = offset1;
        }
        
        if (car2.activeInHierarchy)
        {
            player = car2.transform;
            offset = offset2;
        }
        
        if (car3.activeInHierarchy)
        {
            player = car3.transform;
            offset = offset3;
        }
    }

    private void FixedUpdate()
    {
        CameraTranslation();
        CameraRotation();
     
    }

    private void CameraTranslation()
    {
        var TargetPos = player.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, TargetPos, speed * Time.deltaTime);
    }

    private void CameraRotation()
    {
        var direction = player.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
