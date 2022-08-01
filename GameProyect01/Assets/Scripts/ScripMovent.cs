using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripMovent : MonoBehaviour
{
    public float speed; 
    public GameObject munition;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
       Move();
       //Shoot();

    }
    private void Move(){

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(moveHorizontal, 0, moveVertical) * speed * Time.deltaTime;
    }
    private void Shoot(){
        Instantiate(munition, transform.position, transform.rotation);
    }
  
    
}
