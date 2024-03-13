using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        print("destroy");
    }
}
