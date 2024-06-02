using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAnimation : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Animator>().enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
      
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
