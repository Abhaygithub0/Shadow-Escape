using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
   
    private Vector3 CurrentCheckPoint;
    [SerializeField] GameObject checkPoint1, checkPoint2, checkPoint3, checkPoint4, checkPoint5;
    
   

    void Start()
    {
        
        CurrentCheckPoint = gameObject.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("CheckPoint"))
        {
            
            CurrentCheckPoint = other.gameObject.transform.position; // i want to store the position of other.gameobject into currentcheckpoint so i can use it in future.
        }
    }

   public void Respawn()
    {
        gameObject.transform.position = CurrentCheckPoint;  
    }
}
