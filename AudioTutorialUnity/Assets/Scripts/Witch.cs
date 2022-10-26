/***
 * Author: Stu Dent
 * Create: 10/18/22
 * Modified: 10/26/2022
 * Description: triggers the witch animation and sound cackle
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    public string animtionParamater;
    Animator anim;
    AudioSource audioSrc;
    AudioClip audioClp;


    private void Start()
    {
        anim = GetComponent<Animator>();
        audioSrc = GetComponent<AudioSource>();
        audioClp = audioSrc.clip;
    }

private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            //anim.SetBool(animtionParamater, true);
            anim.SetTrigger(animtionParamater);
        }
    }

    void playCackle()
    {
        audioSrc.PlayOneShot(audioClp);
    }
/*private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(animtionParamater, false);
        }
    }*/





}
