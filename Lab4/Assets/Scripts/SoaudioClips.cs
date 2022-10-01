using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Create AudioClips", fileName = "New AudioClips")]
public class SoaudioClips : ScriptableObject
{
    [SerializeField] private AudioClip[] audioClips;

    public AudioClip GetAudioCilp()
    {
        var totalAudioCilps = audioClips.Length;
        int index;

        switch (totalAudioCilps)
        {
            case 1:
                index = 0;
                break;
            default:
                index = Random.Range(0,totalAudioCilps);
                break;
        }
        return audioClips[index];
    }
}
