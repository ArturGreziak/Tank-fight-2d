using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] GameObject shootPlayer;

    // Start is called before the first frame update
    void Start()
    {
        // GameObject shoot = Instantiate(shootPlayer);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            UtworzNowyPociskNaScenie();
            PobierzPozycjeKursora();
        }
    }

    void UtworzNowyPociskNaScenie(){
        GameObject shoot = Instantiate(shootPlayer);
        Vector3 pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        pos.z = 0;
        shoot.transform.position = gameObject.transform.position;
    }

    void PobierzPozycjeKursora(){
        
    }
}
