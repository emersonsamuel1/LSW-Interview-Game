using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]private AudioClip[] audioClips;
    [SerializeField]private AudioSource[] audioSource;

    public void PlaySound(int index)
    {
        audioSource[0].clip = audioClips[index];
        audioSource[0].pitch = Random.Range(0.8f,1.2f);
        audioSource[0].Play();
    }

    public void PlayBuyingSound()
    {
        audioSource[1].clip = audioClips[3];
        audioSource[1].pitch = Random.Range(1.1f,1.2f);
        audioSource[1].Play();
    }

        public void PlaySellingSound()
    {
        audioSource[1].clip = audioClips[3];
        audioSource[1].pitch = Random.Range(0.8f,0.9f);
        audioSource[1].Play();
    }
}
