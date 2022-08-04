using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawn;
    bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Shout();
    }
    private void SpawnBullet()
    {
        Instantiate(spawn, transform.position, transform.rotation);
    }
    private void Shout()
    {
        if (canShoot)
        {
            canShoot = false;
            SpawnBullet();
            Invoke("ResetShoot", 2f);
        }
        
    }
    void ResetShoot()
        {
            canShoot = true;
        }
}
