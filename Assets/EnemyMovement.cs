using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    
    GameObject gracz;
    Vector3 pozycjaGracza;
    Vector3 kierunek;
    [SerializeField] float Speed =10f;
    // Start is called before the first frame update
    void Start()
    {
        gracz = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        ZnajdujGracza();
        PoruszajSieWkierunkuGracza();
        if (gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    void ZnajdujGracza(){
        if(gracz != null){
            pozycjaGracza = gracz.transform.position;
        }
    }

    void PoruszajSieWkierunkuGracza(){
        kierunek = pozycjaGracza - transform.position;
        transform.position += kierunek.normalized * Speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Shoot")
        {
            // ScoreScript.scoreValue += 4;
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        // if (other.gameObject.tag == "Player")
        // {
        //     Destroy(other.gameObject);
        //     Destroy(gameObject);
        //     // Time.timeScale = 0;
        //     SceneManager.LoadScene(0);
        // }
    }
}
