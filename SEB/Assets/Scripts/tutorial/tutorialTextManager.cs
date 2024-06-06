using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class tutorialTextManager : MonoBehaviour
{
    public TextMeshProUGUI tutorialText;
    public GameObject tutorialTextObject;
    public GameObject spider;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            textCountHandler.count++;
            switch (textCountHandler.count)
            {
                case 1:
                    tutorialText.text = "You can only get the diamonds from your element, use the yellow button to change betweeen water and fire!";
                    break;
                case 2:
                    tutorialText.text = "Be careful with fire pools, they evaporate water!";
                    break;
                case 3:
                    tutorialText.text = "You can guess what happens with water pools and fire...";
                    break;
                case 4:
                    tutorialText.text = "Venom is dangerous for both of them, careful!";
                    break;
                case 5:
                    tutorialText.text = "You are not alone here... Press the blue button to fire water/fire balls and kill the enemies that are coming";
                    InitializeSpiders();
                    break;
                case 6:
                    tutorialText.text = "Well done! You are ready to play now :)";
                    break;
                default:
                    break;
            }
            tutorialTextObject.SetActive(true);
            Invoke("DeactivateTutorialText", 4);
            Destroy(gameObject);
        }
    }


    void DeactivateTutorialText()
    {
        tutorialTextObject.SetActive(false);
    }

    void InitializeSpiders()
    {
        Instantiate(spider, new Vector3(80f, 1.5f, 0), gameObject.transform.rotation);
        Instantiate(spider, new Vector3(83f, 1.5f, 0f), gameObject.transform.rotation);
    }
}
