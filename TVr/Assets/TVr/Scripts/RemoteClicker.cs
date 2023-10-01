using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class RemoteClicker : MonoBehaviour
{
    public AudioClip remoteClick;
    private AudioSource audioSource;
    [SerializeField]
    private VideoPlayer videoPlayer;
    public List<VideoClip> videos;
    VideoClip previousClip;
    VideoClip currentClip;
    VideoClip nextClip;
    private int listCounter;


    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        listCounter = 0;
        if (videos.Count >= 1)
        {
            currentClip = videos[listCounter];
            videoPlayer.clip = currentClip;
        }
        else
        {
            Debug.Log("no videos!");
        }

        // controller = GetComponent<XRController>();
    }


    public void play()
    {
        audioSource.PlayOneShot(remoteClick);
        videoPlayer.Play();
        }

    public void pause()
    {
        audioSource.PlayOneShot(remoteClick);
        videoPlayer.Pause();
    }




    public void skipforward()
    {
        double frame = 0.0;

        frame = videoPlayer.frameCount * 0.05;
        audioSource.PlayOneShot(remoteClick);
        videoPlayer.frame += (long)frame;
    }

    public void skipbackward()
    {
        double frame = 0.0;

        frame = videoPlayer.frameCount * 0.05;
        audioSource.PlayOneShot(remoteClick);
        videoPlayer.frame -= (long)frame;
    }

    public void nextVideo()
    {
        if (listCounter+1 < videos.Count) {
            nextClip = videos[listCounter+1];
            previousClip = currentClip;
            currentClip = nextClip;
            videoPlayer.clip = currentClip;
            audioSource.PlayOneShot(remoteClick);
            videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
            videoPlayer.EnableAudioTrack(0, true);
            videoPlayer.SetTargetAudioSource(0, audioSource);
            videoPlayer.controlledAudioTrackCount = 1;
            audioSource.volume = 1.0f;
            videoPlayer.Play();
            listCounter++;
        }
        else
        {
            listCounter = 0;
            nextClip = videos[listCounter];
            previousClip = currentClip;
            currentClip = nextClip;
            videoPlayer.clip = currentClip;
            audioSource.PlayOneShot(remoteClick);
            videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
            videoPlayer.EnableAudioTrack(0, true);
            videoPlayer.SetTargetAudioSource(0, audioSource);
            videoPlayer.controlledAudioTrackCount = 1;
            audioSource.volume = 1.0f;
            videoPlayer.Play();
            listCounter++;
        }

    }

    public void prevVideo()
    {
        if (listCounter <= videos.Count && listCounter > 0)
        {
            previousClip = videos[listCounter - 1];
            nextClip = currentClip;
            currentClip = previousClip;
            videoPlayer.clip = currentClip;
            audioSource.PlayOneShot(remoteClick);
            videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
            videoPlayer.EnableAudioTrack(0, true);
            videoPlayer.SetTargetAudioSource(0, audioSource);
            videoPlayer.controlledAudioTrackCount = 1;
            audioSource.volume = 1.0f;
            videoPlayer.Play();
            listCounter--;
        }
        else
        {
            listCounter = (videos.Count);
            previousClip = videos[listCounter-1];
            nextClip = currentClip;
            currentClip = previousClip;
            videoPlayer.clip = currentClip;
            audioSource.PlayOneShot(remoteClick);
            videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
            videoPlayer.EnableAudioTrack(0, true);
            videoPlayer.SetTargetAudioSource(0, audioSource);
            videoPlayer.controlledAudioTrackCount = 1;
            audioSource.volume = 1.0f;
            videoPlayer.Play();
            listCounter--;
        }
    }

    public void Quit()
    {
        audioSource.PlayOneShot(remoteClick);
        Application.Quit();
    }


}

