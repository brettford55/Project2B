using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    [SerializeField] float minX = -300f;
    [SerializeField] float maxX = -320f;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 convPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 basketPos = transform.position;
        basketPos.x = convPos.x;
        basketPos.x = Mathf.Clamp(convPos.x, minX, maxX);
        transform.position = basketPos;
           
    }

    private void OnCollisionEnter2D(Collision2D collide)
    {
        if(collide.gameObject.tag == "Apple")
        {

            FindObjectOfType<GameStatus>().AddToScore();
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
