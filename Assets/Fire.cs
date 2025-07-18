using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float  bulletSpeed = 10f;

    public void FireBullet(){
        GameObject SpawnBullet =  Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        SpawnBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;
    }
}
