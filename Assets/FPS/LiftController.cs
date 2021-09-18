using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Lift")
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            if (Input.GetKeyDown(KeyCode.F))
                anim.SetTrigger("DownUp");
        }
    }
}
