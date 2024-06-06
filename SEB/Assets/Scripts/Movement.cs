using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float turnSpeed;

    private void Update()
    {
        var vertical = Input.GetAxis ("Vertical");
        var horizontal = Input.GetAxis ("Horizontal");
        if (vertical != 0f ) {
            transform.Translate (vertical * moveSpeed * Time.deltaTime * Vector3.forward);
        }
        if (horizontal != 0f) {
            transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime * horizontal);
        }
    }
}
