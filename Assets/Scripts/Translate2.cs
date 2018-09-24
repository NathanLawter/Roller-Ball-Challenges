using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate2 : MonoBehaviour
{
    Vector3 pointA = new Vector3(2.64f, -6.19f, -17.75f);
    Vector3 pointB = new Vector3(-2.64f, -6.19f, -17.75f);
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}


