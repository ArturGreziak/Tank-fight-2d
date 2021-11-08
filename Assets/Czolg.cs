using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Czolg : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        FindObjectOfType<ManagerPunktow>().DodajPunkty();
        Destroy(gameObject);
        Destroy(other.gameObject);

        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            // Time.timeScale = 0;
            SceneManager.LoadScene(0);
        }
    }
}
