using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] float Speed = 2f;
    Vector3 pozycjaKursora;
    Vector3 kierunek;
    void Start()
    {
        pozycjaKursora = Input.mousePosition;
        pozycjaKursora = Camera.main.ScreenToWorldPoint(pozycjaKursora);
        pozycjaKursora.z = 0;
        kierunek = pozycjaKursora - transform.position;
        Destroy(gameObject,2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += kierunek.normalized * Time.deltaTime * Speed;
    }
}
