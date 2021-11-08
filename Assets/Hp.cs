using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public int hp = 5;
    public void TakeDamage(int attack)
    {
        hp -= attack;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}