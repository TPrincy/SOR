using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectrotator : MonoBehaviour
{
    float rotaSpeed;

    void Update()
    {
        transform.Rotate(0f, rotaSpeed * time.deltaTime, 0f, Space.Self)
    }
}
