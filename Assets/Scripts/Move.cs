using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float forse = 100f;
    public float rotat = 1f;
    public float camRotateX = 5f;
    public float bashtRotatX = 10f;
    public float MaxBashtRotatX = 0.1f;
    public float bashtRotatY = 5f;
    public float MaxBashtRotatY = 0.1f;
    public float StelBashtY = 5f;
    public float FlorBashtY = -30f;
    public Rigidbody rb;
    public Transform bashta;
    public Transform stvol;
    public Transform cam;
    private float currForse;
    private void Start()
    {
        currForse = forse * rb.mass * 0.0001f;
    }

    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * currForse * ver);
        transform.Rotate(new Vector3(0, rotat * horiz, 0));

        MoveCam(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        MoveBasht();
    }
    void MoveBasht()
    {
        float delta = cam.rotation.eulerAngles.y - bashta.rotation.eulerAngles.y;
        delta = delta % 360;
        if (Mathf.Abs(delta) > 180)
            delta = delta - 360;//
        if (delta > MaxBashtRotatX)
            delta = MaxBashtRotatX;
        if (delta < -MaxBashtRotatX)
            delta = -MaxBashtRotatX;
        bashta.Rotate(new Vector3(0, camRotateX * delta, 0));
    }
    void MoveCam(float toRotateX, float toRotateY)
    {
        cam.Rotate(new Vector3(0, camRotateX* toRotateX, 0));

        //if (toRotateY > MaxBashtRotatY)
        //    toRotateY = MaxBashtRotatY;
        //if (toRotateY < -MaxBashtRotatY)
        //    toRotateY = -MaxBashtRotatY;

        //float newY = -bashtRotatY * toRotateY;

        //if (newY + stvol.rotation.eulerAngles.x > StelBashtY)
        //{
        //    Debug.Log($"S - n{newY} c{stvol.rotation.eulerAngles.x}");
        //    //newY = StelBashtY - stvol.rotation.eulerAngles.x;
        //    stvol.rotation = new Quaternion(StelBashtY, 0f, 0f, 0f);
        //    newY = 0;

        //}
        //else if (newY - stvol.rotation.eulerAngles.x < FlorBashtY)
        //{
        //    Debug.Log($"F - n{newY} c{stvol.rotation.eulerAngles.x}");//bugs
        //                                                              //newY = -FlorBashtY + stvol.rotation.eulerAngles.x;
        //    stvol.rotation = new Quaternion(FlorBashtY, 0f, 0f,0f);
        //    newY = 0;
        //    //Debug.Log(newY);
        //}

        //stvol.Rotate(new Vector3(newY, 0, 0));
    }
}
