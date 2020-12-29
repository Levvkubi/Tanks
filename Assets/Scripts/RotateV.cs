using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateV : MonoBehaviour
{
    public Rigidbody rb;
    public float rot = 1f;
    private void Awake()
    {
        rb.maxAngularVelocity = Mathf.Infinity;
    }
    void FixedUpdate()
    {
        rb.AddTorque( rot,0, 0);
    }
}
