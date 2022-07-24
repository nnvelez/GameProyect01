using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripMoventHpAcc : MonoBehaviour
{
public int Hp;
public Vector3 InicialPosition;
public Vector3 MovemenDirection;
public float Aceleration;
public int Healing;
public int DamageDealt;


    // Start is called before the first frame update
    void Start()
    {
        
        ChangePosition(InicialPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
        Heal(Healing);
        Damage(DamageDealt);
        Aceleration1(Aceleration);

    }

    void Heal(int value)
    {
        Hp = Hp + value;

    }
    void Damage(int value)
    {
        Hp = Hp - value;

    }
    void ChangePosition(Vector3 movement)
    {
        transform.position += movement;

    }
    
    void Aceleration1(float value)
    {
        transform.position -= (transform.right) * (value * Time.deltaTime);
    }
}
