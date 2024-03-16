using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questManager : MonoBehaviour
{
    public ObjectInteract ObjectInteract;
    
    public bool isInRange = false;
    public GameObject InteractText;
    public GameObject ScrollUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isInRange)
        {
            Destroy(gameObject);
            InteractText.SetActive(false);
            ScrollUI.SetActive(true);
        }
    }
}
