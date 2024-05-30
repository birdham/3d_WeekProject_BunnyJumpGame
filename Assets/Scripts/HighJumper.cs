using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighJumper : MonoBehaviour
{
    public float impulseForce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRb != null)
            {
                playerRb.AddForce(Vector3.up * impulseForce, ForceMode.Impulse);
            }
        }
    }
}
