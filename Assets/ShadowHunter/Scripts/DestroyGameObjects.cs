using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObjects : MonoBehaviour
{
    [SerializeField] GameObject GameobjectAssets;
    [SerializeField] bool IsScalable;
    [SerializeField] Vector3 minscale;
    [SerializeField] Vector3 maxscale;
    [SerializeField] float scalingDuration = 1f;

    private bool scalingUp = true;
    private float scalingTimer = 0f;

    private void Update()
    {
        if (IsScalable)
        {
            Scalable();
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null)
        {
            SoundManager.Instance.play(soundplaces.genricPickup);
            Destroy(GameobjectAssets);
            Destroy(gameObject);
        }
    }

    void Scalable()
    {
        scalingTimer = scalingTimer + Time.deltaTime;

        if (scalingUp)
        {
            transform.localScale = Vector3.Lerp(minscale, maxscale, scalingTimer / scalingDuration);
        }
        else
        {
            transform.localScale = Vector3.Lerp(maxscale, minscale, scalingTimer / scalingDuration);
        }

        if (scalingTimer >= scalingDuration)
        {
            scalingTimer = 0f;
            scalingUp = !scalingUp;
        }
    }
    
  
    
}
