using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FireHealthManager : MonoBehaviour
{
    [SerializeField] private PlayerController player; 
    private AudioSource source;
    public dyingController diying;
    // Start is called before the first frame update
    void Start()
    {
        source = player.gameObject.GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("kills fire") || other.CompareTag("kills both"))
        {
            diying.die();
            HealthManager.hasItem = false;
            source.PlayOneShot(player.dyingSound, 1f);
            HealthManager.health--;
            if (HealthManager.health > 0)
            {
                player.transform.position = player.respawnPosition;
               }
            else
            {
                HealthManager.health = 3;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                pointCounter.PointCount = 0;
            }
        }

    }
}
