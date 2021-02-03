using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShotCounter : MonoBehaviour
{
    public Text descriptionText;
    public int shotsFired;

   
    // Update is called once per frame
    public void ShotsFired()
    {
        descriptionText.text = "Shots fired: " + shotsFired;
    }

    public void ResetShotsFired()
    {
        shotsFired = 0;
        descriptionText.text = ">_<";
    }
}
