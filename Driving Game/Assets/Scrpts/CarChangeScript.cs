using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChangeScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    void Start()
    {
        if (GlobalCarChanger.GlobalCarChangerz.small)
        {
            car1.SetActive(true);
        }

        if (GlobalCarChanger.GlobalCarChangerz.ntscar)
        {
            car2.SetActive(true);
        }

        if (GlobalCarChanger.GlobalCarChangerz.truck)
        {
            car3.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
