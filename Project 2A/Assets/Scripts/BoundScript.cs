using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundScript : MonoBehaviour
{
    AudioSource audioSource;
    private void OnCollisionEnter2D(Collision2D collide)
    {
        if (collide.gameObject.tag == "Apple")
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.volume = PlayerPrefsController.GetSFXVolume();
            audioSource.Play();
            Destroy(collide.gameObject);
        }

       

    }
    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
