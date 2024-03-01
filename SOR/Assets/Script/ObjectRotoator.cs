using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotoator : MonoBehaviour
{
    public float rotaSpeed;

    void Update()
    {
        rotation();


    }

    private void rotation()
    {
        transform.Rotate(0f, rotaSpeed * Time.deltaTime, 0f, Space.Self);
    }
}
