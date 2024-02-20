using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlaySoundOnCollision : MonoBehaviour
{
    public Rigidbody myRigidbody; // The Rigidbody of the GameObject that will trigger the sound
    public AudioClip collisionSound; // The sound to be played on collision

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() == myRigidbody)
        {
            if (collisionSound != null)
            {
                audioSource.PlayOneShot(collisionSound);
            }
        }
    }
}
