using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private SoaudioClips walkAudioClips;
    [SerializeField] private SoaudioClips jumpAudioClips;
    [SerializeField] private SoaudioClips fallonImpactAudioClips;
    [SerializeField] private SoaudioClips deadAudioClips;
    [SerializeField] private SoaudioClips winningAudioClips;
    [SerializeField] private SoaudioClips jumpPadAudioClips;
    [SerializeField] private SoaudioClips collectedAudioClips;
    [SerializeField] private SoaudioClips respawnedAudioClips;


    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpAudioClips.GetAudioCilp(),0.5f);
    }

    public void PlayWalkSound()
    {
        audioSource.PlayOneShot(walkAudioClips.GetAudioCilp());
    }

    public void FallonImpactkSound()
    {
        audioSource.PlayOneShot(fallonImpactAudioClips.GetAudioCilp());
    }

    public void DeadSound()
    {
        audioSource.PlayOneShot(deadAudioClips.GetAudioCilp());
    }

    public void WinningSound()
    {
        audioSource.PlayOneShot(winningAudioClips.GetAudioCilp());
    }

    public void JumpPadSound()
    {
        audioSource.PlayOneShot(jumpPadAudioClips.GetAudioCilp());
    }

    public void CollectedkSound()
    {
        audioSource.PlayOneShot(collectedAudioClips.GetAudioCilp());
    }

    public void RespawnedSound()
    {
        audioSource.PlayOneShot(respawnedAudioClips.GetAudioCilp());
    }

    
}
