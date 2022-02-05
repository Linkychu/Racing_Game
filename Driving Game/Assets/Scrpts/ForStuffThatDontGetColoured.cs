using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForStuffThatDontGetColoured : MonoBehaviour
{
    private Renderer rend;

    private GameObject colourAll;

    private ColourChange _colourChange;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        LookForColour();
        _colourChange = colourAll.GetComponent<ColourChange>();

        if (gameObject.CompareTag("Car"))
        {
            MyRendererC();
        }

        if (gameObject.CompareTag("Wheel"))
        {
            MyRendererW();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (colourAll == null)
        {
            LookForColour();
        }
        
        
    }

    void LookForColour()
    {
        colourAll = GameObject.FindWithTag("ColourAll");
    }


    public void MyRendererC()
    {
        rend.material.color = _colourChange.globalColC;
    }

    public void MyRendererW()
    {
        rend.material.color = _colourChange.globalColW;
    }
}
