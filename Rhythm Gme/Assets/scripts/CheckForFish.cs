using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForFish : MonoBehaviour
{
    private GameObject bButton, rButton, yButton, gButton;
    private bool inBlue, inRed, inGreed, inYellow;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ActiveBlue")
        {
            print("Blue object has arrow!!!");
            inBlue = true;
            bButton = other.gameObject;
        }
        if (other.tag == "ActiveGreen")
        {
            inGreed = true;
            gButton = other.gameObject;
        }
        if (other.tag == "ActiveRed")
        {
            inRed = true;
            rButton = other.gameObject;
        }
        if (other.tag == "ActiveYellow")
        {
            inYellow = true;
            yButton = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ActiveBlue")
        {
            inBlue = false;
        }
        if (other.tag == "ActiveGreen")
        {
            inGreed = false;
        }
        if (other.tag == "ActiveRed")
        {
            inRed = false;
        }
        if (other.tag == "ActiveYellow")
        {
            inYellow = false;
        }
    }

    public void RedButtonPressed()
    {
        if (inRed)
        {
            inRed = false;
            rButton.SetActive(false);
        }
    }
    public void GreedButtonPressed()
    {
        if (inGreed)
        {
            inGreed = false;
            gButton.SetActive(false);
        }
    }
    public void BlueButtonPressed()
    {
        if (inBlue)
        {
            inBlue = false;
            bButton.SetActive(false);
        }
    }
    public void YellowButtonPressed()
    {
        if (inYellow)
        {
            inYellow = false;
            yButton.SetActive(false);
        }
    }

}