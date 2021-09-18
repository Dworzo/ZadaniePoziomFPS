using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour
{
    public GameObject instructions;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Lift")
        {
            instructions.SetActive(true);
            Animator anim = other.GetComponentInChildren<Animator>();
            if (Input.GetKeyDown(KeyCode.F))
                anim.SetTrigger("DownUp");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Lift")
        {
            instructions.SetActive(false);
        }
    }
}
