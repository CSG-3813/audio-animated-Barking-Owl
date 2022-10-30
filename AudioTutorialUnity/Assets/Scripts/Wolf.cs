/*
 * Author: Andrew Nguyen
 * Created: 30 Oct. 2022
 * Modified: 30 Oct. 2022
 * Description: Manages wolf animation/audio
 * 
 * 
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    public string animParam;
    Animator animator;
    AudioSource audioSource;
    AudioClip audioClip;


    private void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioClip = audioSource.clip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetTrigger(animParam);
        }
    }

    void Howl()
    {
        audioSource.PlayOneShot(audioClip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
