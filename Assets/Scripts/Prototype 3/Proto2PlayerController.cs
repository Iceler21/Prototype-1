using UnityEngine;

public class Proto2PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.AddForce(Vector3.up * 600);
    }

    void Update()
    {
        
    }
}