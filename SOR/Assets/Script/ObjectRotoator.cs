using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotoator : MonoBehaviour
{
    public float rotaSpeed;
    public float amp;

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
        transform.position = new Vector3(gameObject.transform.localPosition.x, Mathf.Sin(Time.time), gameObject.transform.localPosition.z);
    }

    private void rotation()
    {
        //Line of code to allow the object to slowly rotate at a constant speed determined by the rotaSpeed value
        transform.Rotate(0f, rotaSpeed * Time.deltaTime, 0f, Space.Self);
    }
}
