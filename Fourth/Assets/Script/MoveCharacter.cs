using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curCharacterPosition = transform.position;

        if (count < 300)
        {
            Vector3 movedPosition = new Vector3(curCharacterPosition.x + 0.0008f, curCharacterPosition.y, curCharacterPosition.z);
            transform.position = movedPosition;
            count++;
        }

        if (count >= 300 && count < 600)
        {
            Vector3 movedPosition = new Vector3(curCharacterPosition.x - 0.0008f, curCharacterPosition.y, curCharacterPosition.z);
            transform.position = movedPosition;
            count++;
        }
        if (count == 600)
        {
            count = 0;
        }
    }
}
