using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public float waitToCloseDoor = 3, iTweenSpeed = 3;
    public GameObject door, insideMuseum;

    // Use this to open/close the museum door
    Animator doorAnimator;
    GameObject player;

    void Start()
    {

        if (this.gameObject.name == "LeaveMuseumBack")
        {
            // You are at the back booth and need to get the animator from the Door GameObject
            doorAnimator = door.GetComponent<Animator>();
        }
        else
        {
            // You are already at the door and can get the animator directly
            doorAnimator = GetComponent<Animator>();
        }
    }

    // Open the Door
    public void OpenTheDoor()
    {
        if (this.gameObject.name == "Door")
        {
            player = Camera.main.transform.parent.gameObject;
            iTween.MoveTo(player,
                iTween.Hash(
                    "position", insideMuseum.transform.position,
                    "time", iTweenSpeed,
                    "easetype", "linear"
                )
            );
        }

        doorAnimator.SetTrigger("Open");

        // Wait a few seconds to close the door behind you
        Invoke("CloseTheDoor", waitToCloseDoor);
    }

    // Close the Door
    public void CloseTheDoor()
    {
        doorAnimator.SetTrigger("Close");
    }

}