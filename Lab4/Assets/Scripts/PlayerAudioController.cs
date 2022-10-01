using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private SoaudioClips walkAudioClips;
    [SerializeField] private SoaudioClips jumpAudioClips;

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpAudioClips.GetAudioCilp(),0.5f);
    }

    public void PlayWalkSound()
    {
        audioSource.PlayOneShot(walkAudioClips.GetAudioCilp());
    }
}
