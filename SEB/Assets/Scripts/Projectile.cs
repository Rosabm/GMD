using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        transform.Translate(Time.deltaTime*speed*Vector3.forward);
    }
}
