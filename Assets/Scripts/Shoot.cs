using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public float velosyty = 200f;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newbull = Instantiate(prefab, transform.position, transform.rotation);
            newbull.GetComponent<Rigidbody>().velocity = transform.forward * velosyty;
        }
    }
}
