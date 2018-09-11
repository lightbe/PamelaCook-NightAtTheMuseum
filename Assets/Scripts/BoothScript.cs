using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoothScript : MonoBehaviour
{
    // Use to move the camera from a booth somewhere
    public GameObject nextStop;

    // Use these objects to access the booths and goodbye text when leaving the museum
    public GameObject boothFront, boothBack, goodbyePanel, exitPosition;

    // Use the for audio instructions on the booth
    public AudioSource audioSource, audioSourceMuseum;
    public AudioClip audioFile, audioFileMuseum;
    public float itweenSpeed = 3;
    public int delaySpeed = 3, delaySpeedOpen = 1, delaySpeedExit = 3;

    GameObject player;

    // Disable booths before moving
    public void DisableBoothsBeforeMoving()
    {

        if (this.gameObject.name == "GoToExhibitsFront")
        {
            boothFront.SetActive(false);

            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }

            Invoke("MoveCamera", delaySpeedOpen);

            audioSourceMuseum.clip = audioFileMuseum;
            audioSourceMuseum.Play();

            Invoke("DisplayBackBooth", delaySpeed);

        }
        else
        {
            boothBack.SetActive(false);

            MoveCamera();

            Invoke("DisplayFrontBooth", delaySpeed);
        }

    }

    void MoveCamera()
    {

        if (this.gameObject.name == "LeaveMuseumBack")
        {
            audioSource.Stop();
            //Display the exit museum position before moving the camera
            exitPosition.SetActive(true);
        }

        player = Camera.main.transform.parent.gameObject;
        iTween.MoveTo(player,
            iTween.Hash(
                "position", nextStop.transform.position,
                "time", itweenSpeed,
                "easetype", "linear"
            )
        );

        if (this.gameObject.name == "LeaveMuseumBack")
        {
            // Display the goodbye panel on the path
            Invoke("DisplayGoodbyeText", delaySpeedExit);
        }
    }

    void DisplayFrontBooth()
    {
        boothFront.SetActive(true);
    }

    void DisplayBackBooth()
    {
        boothBack.SetActive(true);
    }

    void DisplayGoodbyeText()
    {
        goodbyePanel.SetActive(true);
    }

}