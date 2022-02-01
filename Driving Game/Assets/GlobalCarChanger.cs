using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GlobalCarChanger : MonoBehaviour
{
    public static GlobalCarChanger GlobalCarChangerz { get; protected set; }
    public bool small;
    public bool ntscar;
    public bool truck;

    private void Awake()
    {
        if (GlobalCarChangerz == null)
        {
            GlobalCarChangerz = this;
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SmallCar()
    {
        small = true;
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    
    public void NCar()
    {
        ntscar = true;
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    
    public void Truck()
    {
        truck = true;
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
