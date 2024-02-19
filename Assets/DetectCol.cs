using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCol : MonoBehaviour
{
    private int P1 = 0;

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player2"))
        {
            P1 = P1 + 1;

            // Get a reference to the ChangeMaterialColor script
            ChangeMaterialColor changeColorScript = other.gameObject.GetComponent<ChangeMaterialColor>();

            // If the script exists, call its ChangeToRandomColor method
            if (changeColorScript != null)
            {
                changeColorScript.ChangeToRandomColor();
            }

            Debug.Log("Player 1 Score: " + P1);
        }
    }
}
