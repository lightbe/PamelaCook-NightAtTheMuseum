using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MuseumScript : MonoBehaviour
{

    // Use these objects to move the camera from current position to another througout the museum
    public GameObject startPoint, firstStartPoint;
    public float speedFirst = 2, speedExhibit = 2, speedCrossStreet = 1, waitToCross = 5;
    bool crossingTheStreet = true;
    GameObject player;

    // Use this for initialization
    void Start()
    {

        // Update 'player' to be the camera's parent gameobject, i.e. 'GvrEditorEmulator' instead of the camera itself.
        // Required because GVR resets camera position to 0, 0, 0.
        player = Camera.main.transform.parent.gameObject;

        // Move the 'player' to the 'startPoint' position.
        // player.transform.position = startPoint.transform.position;
        iTween.MoveTo(player,
            iTween.Hash(
                "position", startPoint.transform.position,
                "time", speedFirst,
                "easetype", "linear"
            )
        );

        Invoke("MoveToFirstPoint", waitToCross);

    }

    // Move to the first point to stop the camera
    public void MoveToFirstPoint()
    {
        if (crossingTheStreet)
        {
            iTween.MoveTo(player,
                iTween.Hash(
                    "position", firstStartPoint.transform.position,
                    "time", speedCrossStreet,
                    "easetype", "linear"
                )
            );
            crossingTheStreet = false;
        }
        else
        {
            iTween.MoveTo(player,
                iTween.Hash(
                    "position", firstStartPoint.transform.position,
                    "time", speedExhibit,
                    "easetype", "linear"
                )
            );
        }
    }

}