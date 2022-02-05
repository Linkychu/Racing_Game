using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColourChange : MonoBehaviour
{
    public Slider carR;
    public Slider carG;
    public Slider carB;
    public Slider WheelR;
    public Slider WheelG;
    public Slider WheelB;

    private GameObject car;
    private GameObject[] wheels;

    private Renderer carRend;

    private Renderer[] _Wheelrenders;

    private Renderer wheelRend;

    private Transform carT;

    private Transform wheelParent;

    public Color globalColW;
    public Color globalColC;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateCar();
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateCar()
    {
        car = GameObject.FindWithTag("Player");
        
        foreach (Transform component in car.transform)
        {

            if (component.CompareTag("Car"))
            {
                carRend = component.GetComponent<Renderer>();
            }
            
            
        }

        if (carRend == null)
        {
            for (int  i = 0;  i <  car.transform.childCount;  i++)
            {
                Transform Child = car.transform.GetChild(i);
                carRend = Child.GetComponentInChildren<Renderer>();

                if (carRend == null)
                {
                    i++;
                }
            }
        }
    }
    



    // Update is called once per frame
    void Update()
    {
        
    }

    public void CarColour()
    {
        carRend.material.color = new Color(carR.value, carG.value, carB.value);
        globalColC = carRend.material.color;
    }

    public void WheelColour()
    {
        wheelParent = GameObject.FindWithTag("WheelParent").GetComponent<Transform>();

        for (int i = 0; i < wheelParent.childCount; i++)
        {
            Transform child = wheelParent.GetChild(i);
            wheelRend = child.GetComponent<Renderer>();

          wheelRend.material.color = new Color(WheelR.value, WheelG.value, WheelB.value);

        }
      //  wheelRend.material.color = new Color(WheelR.value, WheelG.value, WheelB.value);


             globalColW = wheelRend.material.color;


    }

    public void BreakCar()
    {
        carRend = null;
    }
}
