using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;

    [SerializeField] private Vector3 offset;

    [SerializeField] private float speed;
    // Start is called before the first frame update
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
