using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Fungus;
using DialogueEditor;
using Unity.VisualScripting;

public class interactionsManager : MonoBehaviour
{

    [Header("Script References")]
    public questManager questManager;
    public SceneSwitcher sceneSwitcher;

    void Update()
    {

    }

    void Start()
    {
        //Ensures that when the gamestart the interact text is disabled from start
        questManager.InteractText.SetActive(false);
    }

    public void mainMenuInteract()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            sceneSwitcher.goToMainMenu();
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        //enables the interact text when the player enters the detection box of the interactable object
        questManager.InteractText.SetActive(true);
    }

    void OnTriggerStay(Collider other)
    {
        //compares the tags of tigger box holder then turns on the bool it relates to
        if (CompareTag("Scroll"))
        {
            questManager.isInRangeScroll = true;
        }
        else if (CompareTag("Bow"))
        {
            questManager.isInRangeBow = true;
        }
        else if (CompareTag("Cleric"))
        {
            questManager.isInRangeClericNPC = true;
        }
        else if (CompareTag("Archer"))
        {
            questManager.isInRangeArcherNPC = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //this deactivates the bools meaning that we don't get a misfire on dialogue when the player enters another character interaction range
        questManager.isInRangeScroll = false;
        questManager.isInRangeBow = false;
        questManager.isInRangeClericNPC = false;
        questManager.isInRangeArcherNPC = false;
        
        //disables the interact text when the player leaves the detection range of the object
        questManager.InteractText.SetActive(false);
    }


}
