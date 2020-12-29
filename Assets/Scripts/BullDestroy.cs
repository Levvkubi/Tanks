using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullDestroy : MonoBehaviour
{
    private int TimeOfLife = 200;
    private void FixedUpdate()
    {
        if (TimeOfLife > 0)
            TimeOfLife--;
        else
            Destroy(gameObject);
    }
}
