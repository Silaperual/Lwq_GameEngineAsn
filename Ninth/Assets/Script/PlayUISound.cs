using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayUISound : MonoBehaviour
{
    public string eventPlay = null;
    public string eventStop = null;
    private bool isPlaying = false;
    // Start is called before the first frame update

    public void Control()
    {
        GameObject mainCamera = GameObject.Find("Main Camera");
        if (!string.IsNullOrEmpty(eventPlay))
        {
            if(isPlaying == false)
            {
                AkSoundEngine.PostEvent(eventPlay, mainCamera);
                isPlaying = true;
            }
            else
            {
                AkSoundEngine.PostEvent(eventStop, mainCamera);
                isPlaying = false;
            }
        }

        }
    }
