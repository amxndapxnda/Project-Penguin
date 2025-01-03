using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    [SerializeField] private GameObject interactCanvas;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("The player has entered the trigger!");
        interactCanvas.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        interactCanvas.SetActive(false);
    }
}
