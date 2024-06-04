using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    [SerializeField] GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            SoundManager.Instance.play(soundplaces.platformer);
            player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            player.transform.parent = null;
            StartCoroutine(ResetPlayerZPosition());
        }
    }

    private IEnumerator ResetPlayerZPosition()
    {
       
        yield return new WaitForEndOfFrame();

        Vector3 newPosition = player.transform.position;
        newPosition.z = 0;
        player.transform.position = newPosition;
    }
}
