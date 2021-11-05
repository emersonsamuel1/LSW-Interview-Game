using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundManager : MonoBehaviour
{
    [SerializeField]private AudioClip[] audioClips;
    [SerializeField]private AudioSource audiosource;
    [SerializeField]private PlayerInputs playerInputs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PlayWalkingSound()
    {
            audiosource.clip = audioClips[0];
            audiosource.pitch = Random.Range(0.8f,1.2f);
            audiosource.Play();
    }
}
