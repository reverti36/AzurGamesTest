using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnClickScript : MonoBehaviour
{
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySfx(int pitch)
    {
        _audioSource.pitch += .1f;
        this.GetComponent<AudioSource>().Play();
    }
}
