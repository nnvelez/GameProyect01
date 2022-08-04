using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject munition;
    public float spawnTime;
    private bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Shout();
        }


    }

    private void Shout()
    {
        if (canShoot)
        {
            canShoot = false;
            SpawnBullet();
            Invoke("ResetShoot", spawnTime);
        }
    }

    private void SpawnBullet()
    {
        Instantiate(munition, transform.position, transform.rotation);
    }
    private void ResetShoot()
    {
        canShoot = true;
    }

}
