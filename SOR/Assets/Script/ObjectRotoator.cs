using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotoator : MonoBehaviour
{
    public float rotaSpeed;
    public float amp;
    public float freq;

    Vector3 initPos;

    private void Start()
    {
        initPos = transform.position;
    }

    void Update()
    {
        rotation();
        UDmovement();
    }

    private void UDmovement()
    {
        //Small line of code to have the collectable move up and down in the form of a sin wave making it a smooth motion
        transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time * freq) * amp + initPos.y, initPos.z);
    }

    private void rotation()
    {
        //Line of code to allow the object to slowly rotate at a constant speed determined by the rotaSpeed value
        transform.Rotate(0f, rotaSpeed * Time.deltaTime, 0f, Space.Self);
    }
}
