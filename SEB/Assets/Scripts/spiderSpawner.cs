using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class spiderSpawner : MonoBehaviour
{
    public GameObject spider;
    public GameObject bat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            spiderSpawnCounter.count++;
            switch (spiderSpawnCounter.count)
            {
                case 1:
                    Instantiate(spider, new Vector3(127f, 3f, 0), gameObject.transform.rotation);
                    Instantiate(spider, new Vector3(129f, 3f, 0f), gameObject.transform.rotation);
                    break;
                case 2:
                    Instantiate(spider, new Vector3(172f, 3f, 0), gameObject.transform.rotation);
                    Instantiate(spider, new Vector3(175f, 3f, 0f), gameObject.transform.rotation);
                    Instantiate(spider, new Vector3(178f, 3f, 0f), gameObject.transform.rotation);
                    Instantiate(bat, new Vector3(183f, 2.3f, 0f), Quaternion.Inverse(gameObject.transform.rotation));
                    break;
                default:
                    break;
            }
           gameObject.SetActive(false);
        }
    }

}
