using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject playerobj;
    [SerializeField] Vector3 offset;
   

    void Update()
    {
      
        Vector3 playerPosition = playerobj.transform.position;

       
        Vector3 desiredPosition = playerPosition + offset;

       
        transform.position =desiredPosition;
    }
}
