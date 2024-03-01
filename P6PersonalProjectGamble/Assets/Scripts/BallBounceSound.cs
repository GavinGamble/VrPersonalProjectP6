using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceSound : MonoBehaviour
{
    public AudioClip bounceSound; // Assign your bouncing sound effect here
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.spatialBlend = 1; // Set spatial blend to 3D
    }

    void OnCollisionEnter(Collision collision)
    {
        // Play the bouncing sound whenever the ball collides with anything
        audioSource.PlayOneShot(bounceSound);
    }
}

