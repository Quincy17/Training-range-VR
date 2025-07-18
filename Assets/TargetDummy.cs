using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    onCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Bullet hit the target dummy!");
            // Logic to handle the bullet hitting the target dummy
            Destroy(other.gameObject); // Destroy the bullet on impact
            // Additional logic for damage or effects can be added here
        }
    }
}
