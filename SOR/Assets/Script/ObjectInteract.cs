using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectInteract : MonoBehaviour
{
    public bool isInRange = false;
    public GameObject InteractText;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isInRange)
        {
            print("Destroy");
            Destroy(gameObject);
            InteractText.SetActive(false);
        }
    }

    void Start()
    {
        //Ensures that when the gamestart the interact text is disabled from start
        InteractText.SetActive(false);
    }
    
    void OnTriggerEnter(Collider other)
    {
        //enables the interact text when the player enters the detection box of the interactable object
        InteractText.SetActive(true);
    }

    void OnTriggerStay(Collider other)
    {
        isInRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        isInRange = false;
        //disables the interact text when the player leaves the detection range of the object
        InteractText.SetActive(false);
    }
}
