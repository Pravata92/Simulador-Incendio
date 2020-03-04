using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmaSFX : MonoBehaviour
{
    public AudioClip alarmaSFX;
    [SerializeField] private Animator popUpAnimation;
    public GameObject popUp1;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Palanca")
        {
            Debug.Log("sonando");
            GetComponent<AudioSource>().PlayOneShot(alarmaSFX);
            popUpAnimation.SetBool("StartPopUpBool", true);
            popUp1.SetActive(false);
        }
    }
}
