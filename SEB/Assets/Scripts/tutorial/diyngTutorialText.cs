using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class diyngTutorialText : MonoBehaviour
{

    public TextMeshProUGUI tutorialText;
    public GameObject tutorialTextObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
        
            tutorialText.text = "If you die, you'll go back to the beginning :(";
            tutorialTextObject.SetActive(true);
            Invoke("DeactivateTutorialText", 2f);
            Destroy(gameObject);
        }
    }

    void DeactivateTutorialText()
    {
        tutorialTextObject.SetActive(false);
    }
}
