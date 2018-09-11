using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MediaPlayButtons : MonoBehaviour
{
    public GameObject firstPoint, nextPoint;
    public float itweenSpeed = 2, delaySpeed = 1;
    float itweenHalfSpeed;

    // Use the for audio instructions throughout the exhibit
    public AudioSource audioSource, audioSourceRotunda;
    public AudioClip audioFile;
    public AudioSource audioSourceLeft, audioSourceRight,
    audioSourceRightexh, audioSourceMiddleRightexh, audioSourceMiddleexh, audioSourceMiddleLeftexh, audioSourceLeftexh,
    audioSourceRightbio, audioSourceMiddleRightbio, audioSourceMiddlebio, audioSourceMiddleLeftbio, audioSourceLeftbio;

    // Use these objects to play the video in each exhibit room
    public VideoPlayer videoPlayer;
    public Sprite playImage, pauseImage;

    GameObject player;

    // Move to the first point to stop the camera
    public void MoveExhibit()
    {

        if (this.gameObject.name.Contains("ExhibitEnter"))
        {
            audioSource.Stop();
            audioSourceRotunda.Stop();
            ChangeSpritesBio();
            ChangeSpritesIntro();
        }
        else if (this.gameObject.name.Contains("ButtonExit"))
        {
            audioSourceLeft.Stop();
            audioSourceRight.Stop();
            videoPlayer.Stop();
            ChangeSpritesRoom();
        }

        if (firstPoint != null)
        {
            itweenHalfSpeed = itweenSpeed / 2;
            MoveFirstPoint(itweenHalfSpeed);
            Invoke("MoveNextPointDelayed", delaySpeed);
        }
        else
        {
            MoveNextPoint(itweenSpeed);
        }

    }

    public void PlayPauseAudio()
    {

        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            GetComponent<Image>().sprite = playImage;
        }
        else
        {
            if (this.gameObject.name.Contains("ExhibitButton"))
            {
                audioSourceRotunda.Stop();
                StopExhibitAudios();
            }

            audioSource.clip = audioFile;
            audioSource.Play();
            GetComponent<Image>().sprite = pauseImage;

            if (this.gameObject.name.Contains("BoothButton"))
            {
                // Do nothing; no video to stop on booths
            }
            else
            {
                videoPlayer.Stop();
            }

            if (this.gameObject.name.Contains("RoomWallRightButton"))
            {
                if (this.gameObject.name == "RoomWallRightButtonRight")
                {
                    ChangeSpriteToPlayImageStopAudio("RoomWallLeftButtonRight", audioSourceLeft);
                    ChangeSpriteToPlayImage("RoomWallBackButtonRight");
                }
                else if (this.gameObject.name == "RoomWallRightButtonMiddleRight")
                {
                    ChangeSpriteToPlayImageStopAudio("RoomWallLeftButtonMiddleRight", audioSourceLeft);
                    ChangeSpriteToPlayImage("RoomWallBackButtonMiddleRight");
                }
                else if (this.gameObject.name == "RoomWallRightButtonMiddle")
                {
                    ChangeSpriteToPlayImageStopAudio("RoomWallLeftButtonMiddle", audioSourceLeft);
                    ChangeSpriteToPlayImage("RoomWallBackButtonMiddle");
                }
                else if (this.gameObject.name == "RoomWallRightButtonMiddleLeft")
                {
                    ChangeSpriteToPlayImageStopAudio("RoomWallLeftButtonMiddleLeft", audioSourceLeft);
                    ChangeSpriteToPlayImage("RoomWallBackButtonMiddleLeft");
                }
                else if (this.gameObject.name == "RoomWallRightButtonLeft")
                {
                    ChangeSpriteToPlayImageStopAudio("RoomWallLeftButtonLeft", audioSourceLeft);
                    ChangeSpriteToPlayImage("RoomWallBackButtonLeft");
                }
            }
            else if (this.gameObject.name.Contains("RoomWallLeftButton"))
            {
                if (this.gameObject.name == "RoomWallLeftButtonRight")
                {
                    ChangeSpriteToPlayImageStopAudio("RoomWallRightButtonRight", audioSourceRight);
                    ChangeSpriteToPlayImage("RoomWallBackButtonRight");
                }
                else if (this.gameObject.name == "RoomWallLeftButtonMiddleRight")
                {
                    ChangeSpriteToPlayImageStopAudio("RoomWallRightButtonMiddleRight", audioSourceRight);
                    ChangeSpriteToPlayImage("RoomWallBackButtonMiddleRight");
                }
                else if (this.gameObject.name == "RoomWallLeftButtonMiddle")
                {
                    ChangeSpriteToPlayImageStopAudio("RoomWallRightButtonMiddle", audioSourceRight);
                    ChangeSpriteToPlayImage("RoomWallBackButtonMiddle");
                }
                else if (this.gameObject.name == "RoomWallLeftButtonMiddleLeft")
                {
                    ChangeSpriteToPlayImageStopAudio("RoomWallRightButtonMiddleLeft", audioSourceRight);
                    ChangeSpriteToPlayImage("RoomWallBackButtonMiddleLeft");
                }
                else if (this.gameObject.name == "RoomWallLeftButtonLeft")
                {
                    ChangeSpriteToPlayImageStopAudio("RoomWallRightButtonLeft", audioSourceRight);
                    ChangeSpriteToPlayImage("RoomWallBackButtonLeft");
                }
            }
        }

    }

    void MoveFirstPoint(float speed)
    {

        player = Camera.main.transform.parent.gameObject;
        iTween.MoveTo(player,
            iTween.Hash(
                "position", firstPoint.transform.position,
                "time", speed,
                "easetype", "linear"
            )
        );
        Debug.Log("MoveFirstPoint method");

    }

    void MoveNextPoint(float speed)
    {

        player = Camera.main.transform.parent.gameObject;
        iTween.MoveTo(player,
            iTween.Hash(
                "position", nextPoint.transform.position,
                "time", speed,
                "easetype", "linear"
            )
                     );
        Debug.Log("MoveNextPoint method");

    }

    void MoveNextPointDelayed()
    {
        MoveNextPoint(itweenHalfSpeed);
    }

    public void PlayPauseVideo()
    {

        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            GetComponent<Image>().sprite = playImage;
        }
        else
        {
            videoPlayer.Play();
            GetComponent<Image>().sprite = pauseImage;
            audioSourceLeft.Stop();
            audioSourceRight.Stop();

            if (this.gameObject.name == "RoomWallBackButtonRight")
            {
                ChangeSpriteToPlayImageStopAudio("RoomWallLeftButtonRight", audioSourceLeft);
                ChangeSpriteToPlayImageStopAudio("RoomWallRightButtonRight", audioSourceRight);
            }
            else if (this.gameObject.name == "RoomWallBackButtonMiddleRight")
            {
                ChangeSpriteToPlayImageStopAudio("RoomWallLeftButtonMiddleRight", audioSourceLeft);
                ChangeSpriteToPlayImageStopAudio("RoomWallRightButtonMiddleRight", audioSourceRight);
            }
            else if (this.gameObject.name == "RoomWallBackButtonMiddle")
            {
                ChangeSpriteToPlayImageStopAudio("RoomWallLeftButtonMiddle", audioSourceLeft);
                ChangeSpriteToPlayImageStopAudio("RoomWallRightButtonMiddle", audioSourceRight);
            }
            else if (this.gameObject.name == "RoomWallBackButtonMiddleLeft")
            {
                ChangeSpriteToPlayImageStopAudio("RoomWallLeftButtonMiddleLeft", audioSourceLeft);
                ChangeSpriteToPlayImageStopAudio("RoomWallRightButtonMiddleLeft", audioSourceRight);
            }
            else if (this.gameObject.name == "RoomWallBackButtonLeft")
            {
                ChangeSpriteToPlayImageStopAudio("RoomWallLeftButtonLeft", audioSourceLeft);
                ChangeSpriteToPlayImageStopAudio("RoomWallRightButtonLeft", audioSourceRight);
            }
        }

    }

    void StopExhibitAudios()
    {
        if (this.gameObject.name.Contains("ExhibitButtonIntro"))
        {
            ChangeSpritesBio();
        }
        else
        {
            ChangeSpritesIntro();
        }

        if (this.gameObject.name == "ExhibitButtonIntroLeft")
        {
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroRight", audioSourceRightexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddleRight", audioSourceMiddleRightexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddle", audioSourceMiddleexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddleLeft", audioSourceMiddleLeftexh);
        }
        else if (this.gameObject.name == "ExhibitButtonIntroMiddleLeft")
        {
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroRight", audioSourceRightexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddleRight", audioSourceMiddleRightexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddle", audioSourceMiddleexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroLeft", audioSourceLeftexh);
        }
        if (this.gameObject.name == "ExhibitButtonIntroMiddle")
        {
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroRight", audioSourceRightexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddleRight", audioSourceMiddleRightexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddleLeft", audioSourceMiddleLeftexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroLeft", audioSourceLeftexh);
        }
        if (this.gameObject.name == "ExhibitButtonIntroMiddleRight")
        {
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroRight", audioSourceRightexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddle", audioSourceMiddleexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddleLeft", audioSourceMiddleLeftexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroLeft", audioSourceLeftexh);
        }
        if (this.gameObject.name == "ExhibitButtonIntroRight")
        {
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddleRight", audioSourceMiddleRightexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddle", audioSourceMiddleexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddleLeft", audioSourceMiddleLeftexh);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroLeft", audioSourceLeftexh);
        }
        else if (this.gameObject.name == "ExhibitButtonBioLeft")
        {
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioRight", audioSourceRightbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddleRight", audioSourceMiddleRightbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddle", audioSourceMiddlebio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddleLeft", audioSourceMiddleLeftbio);
        }
        else if (this.gameObject.name == "ExhibitButtonBioMiddleLeft")
        {
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioRight", audioSourceRightbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddleRight", audioSourceMiddleRightbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddle", audioSourceMiddlebio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioLeft", audioSourceLeftbio);
        }
        if (this.gameObject.name == "ExhibitButtonBioMiddle")
        {
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioRight", audioSourceRightbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddleRight", audioSourceMiddleRightbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddleLeft", audioSourceMiddleLeftbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioLeft", audioSourceLeftbio);
        }
        if (this.gameObject.name == "ExhibitButtonBioMiddleRight")
        {
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioRight", audioSourceRightbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddle", audioSourceMiddlebio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddleLeft", audioSourceMiddleLeftbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioLeft", audioSourceLeftbio);
        }
        if (this.gameObject.name == "ExhibitButtonBioRight")
        {
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddleRight", audioSourceMiddleRightbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddle", audioSourceMiddlebio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddleLeft", audioSourceMiddleLeftbio);
            ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioLeft", audioSourceLeftbio);
        }

    }

    void ChangeSpritesBio()
    {
        ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioRight", audioSourceRightbio);
        ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddleRight", audioSourceMiddleRightbio);
        ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddle", audioSourceMiddlebio);
        ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioMiddleLeft", audioSourceMiddleLeftbio);
        ChangeSpriteToPlayImageStopAudio("ExhibitButtonBioLeft", audioSourceLeftbio);
    }

    void ChangeSpritesIntro()
    {
        ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroRight", audioSourceRightexh);
        ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddleRight", audioSourceMiddleRightexh);
        ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddle", audioSourceMiddleexh);
        ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroMiddleLeft", audioSourceMiddleLeftexh);
        ChangeSpriteToPlayImageStopAudio("ExhibitButtonIntroLeft", audioSourceLeftexh);
    }

    void ChangeSpritesRoom()
    {

        if (this.gameObject.name == "ButtonExitLeft")
        {
            ChangeSpriteToPlayImage("RoomWallBackButtonLeft");
            ChangeSpriteToPlayImage("RoomWallLeftButtonLeft");
            ChangeSpriteToPlayImage("RoomWallRightButtonLeft");
        }
        else if (this.gameObject.name == "ButtonExitMiddleLeft")
        {
            ChangeSpriteToPlayImage("RoomWallBackButtonMiddleLeft");
            ChangeSpriteToPlayImage("RoomWallLeftButtonMiddleLeft");
            ChangeSpriteToPlayImage("RoomWallRightButtonMiddleLeft");
        }
        else if (this.gameObject.name == "ButtonExitMiddle")
        {
            ChangeSpriteToPlayImage("RoomWallBackButtonMiddle");
            ChangeSpriteToPlayImage("RoomWallLeftButtonMiddle");
            ChangeSpriteToPlayImage("RoomWallRightButtonMiddle");
        }
        else if (this.gameObject.name == "ButtonExitMiddleRight")
        {
            ChangeSpriteToPlayImage("RoomWallBackButtonMiddleRight");
            ChangeSpriteToPlayImage("RoomWallLeftButtonMiddleRight");
            ChangeSpriteToPlayImage("RoomWallRightButtonMiddleRight");
        }
        else if (this.gameObject.name == "ButtonExitRight")
        {
            ChangeSpriteToPlayImage("RoomWallBackButtonRight");
            ChangeSpriteToPlayImage("RoomWallLeftButtonRight");
            ChangeSpriteToPlayImage("RoomWallRightButtonRight");
        }
    }

    void ChangeSpriteToPlayImageStopAudio(string buttonName, AudioSource audioSourceToStop)
    {
        ChangeSpriteToPlayImage(buttonName);
        audioSourceToStop.Stop();
    }

    void ChangeSpriteToPlayImage(string buttonName)
    {
        GameObject.Find(buttonName).GetComponent<Image>().sprite = playImage;
    }


}