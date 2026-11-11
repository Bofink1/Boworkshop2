using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class NpcInteract : MonoBehaviour
{
    [Header("Proximity Alert")]
    public GameObject Proximity;

    [Header("Default Dialogue")]
    public DialogueNode startingDialogue;

   
  

   

    private bool playerInRange = false;

    private void Start()
    {

        Proximity.SetActive(false);

    }


    public void OnInteract(InputAction.CallbackContext context)
    {
        if (playerInRange)
        {
            Debug.Log("hello");
            DialogueNode dialogueToShow = GetAppropriateDialogue();
            FindObjectOfType<DialogueUI>().StartDialogue(dialogueToShow);
        } 
    }

  
    private DialogueNode GetAppropriateDialogue()
    {
      
            return startingDialogue;
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            playerInRange = true;
            Proximity.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            playerInRange = false;
            Proximity.SetActive(false);

        }
    }
}