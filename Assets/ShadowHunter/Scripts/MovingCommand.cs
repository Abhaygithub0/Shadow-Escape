using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCommand : MonoBehaviour
{
    [SerializeField] GameObject obj1, obj2;
    Vector3 newpositionObj1, newpositionObj2, targetPosition;
    [SerializeField] float speedofplatform;

    // Start is called before the first frame update
    void Start()
    {
        newpositionObj1 = obj1.transform.position;
        newpositionObj2 = obj2.transform.position;
        targetPosition = newpositionObj1;
    }

  
    void Update()
    {
      
        gameObject.transform.position = Vector3.MoveTowards( gameObject.transform.position, targetPosition, speedofplatform * Time.deltaTime );

        
        if (gameObject.transform.position == targetPosition)
        {
            
            targetPosition = (targetPosition == newpositionObj1) ? newpositionObj2 : newpositionObj1;
        }
    }
}
