using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LapCount : MonoBehaviour
{
   public static LapCount Instance { get; protected set; }

   public int LapIntCheck;
   public int LapNumber;
   public int TotalLapCheck;
   private TextMeshProUGUI LapInt;
   public GameObject LapIntString;
   private int LapCounter;
   public Transform lapHead;

   public Vector3 lastLapPos;

   [SerializeField]private int lapsToComplete = 3;
   public Quaternion lastPlayerRot;


   private void Awake()
   {
      if (Instance == null)
      {
         Instance = this;
      }
   }

   private void Start()
   {
      LapInt = LapIntString.GetComponent<TextMeshProUGUI>();
      LapInt.text = LapCounter.ToString();
      TotalLapCheck = lapHead.childCount - 1;
   }

   public void LapFinish()
   {
    
         LapNumber += 1;
         LapCounter = LapNumber;
         LapInt.text = LapCounter.ToString();
         LapIntCheck = 0;
         LapBox();

         if (LapNumber > lapsToComplete)
         {
            SceneManager.LoadScene(sceneBuildIndex: 2);
         }

   }
   public void LapBox()
   {
      LapIntCheck += 1;
   }
   
   

 
}
