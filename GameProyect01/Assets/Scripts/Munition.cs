using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Munition : MonoBehaviour
{
    public float speed;
    public float liveTime;
    public float bulletSize;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroDelay", liveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        BulletGrowUp();
    }
    private void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
    private void DestroDelay(){
        Destroy(gameObject);
    }
    private void BulletGrowUp(){
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += transform.localScale * bulletSize;
        }
    }
}
