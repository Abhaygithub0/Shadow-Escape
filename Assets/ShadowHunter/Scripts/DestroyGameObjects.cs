using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObjects : MonoBehaviour
{

    [SerializeField] GameObject GameobjectAssets;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null)
        {
            Destroy(GameobjectAssets);
            Destroy(gameObject);
        }
    }

    
}
