using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    Vector3 pointA = new Vector3(-2.87f, -4.12f, -14.79f);
    Vector3 pointB = new Vector3(2.73f, -4.12f, -14.79f);
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}


