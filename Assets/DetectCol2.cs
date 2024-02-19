using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCol2 : MonoBehaviour
{
    private int P2 = 0;

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            P2 = P2 + 1;

            // Get a reference to the ChangeMaterialColor script
            ChangeMaterialColor changeColorScript = other.gameObject.GetComponent<ChangeMaterialColor>();

            // If the script exists, call its ChangeToRandomColor method
            if (changeColorScript != null)
            {
                changeColorScript.ChangeToRandomColor();
            }

            Debug.Log("Player 2 Score: " + P2);
        }
    }
}
