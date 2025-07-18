using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    [SerializeField] private animator dummyAnimator;
 
    private void onCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("Weapon") )
        {
            duummyAnimator.SetTrigger("Death");
        }
    }

    void activateDummy()
    {
        dummyAnimator.SetTrigger("Activate");
    }
}
