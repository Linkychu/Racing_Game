using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static Timer TimerScript { get; protected set; }
    
    
    public TextMeshProUGUI timer;

    public bool Started;

    public float time;

    public GameObject countDownObj;

    private TextMeshProUGUI countDownText;

    // Start is called before the first frame update

    private void Awake()
    {
        if (TimerScript == null)
        {
            TimerScript = this;
        }
    }

    void Start()
    {
        countDownText = countDownObj.GetComponent<TextMeshProUGUI>();
        StartCoroutine(BeginPlay());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKey(KeyCode.Joystick1Button3))

        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        StopWatch();
    }

    void StopWatch()
    {
        if (Started)
        {
            time += Time.deltaTime;
            float minutes = Mathf.FloorToInt(time / 60);
            float seconds = Mathf.FloorToInt(time % 60);

            timer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        }
    }

    IEnumerator BeginPlay()
    {
        yield return new WaitForSeconds(1);
        countDownText.text = "3";
        yield return new WaitForSeconds(1);
        countDownText.text = "2";
        yield return new WaitForSeconds(1);
        countDownText.text = "1";
        yield return new WaitForSeconds(1);
        countDownText.text = "GO!";
        yield return new WaitForSeconds(1);
        Started = true;
        countDownObj.SetActive(false);
        

    }
    
}
