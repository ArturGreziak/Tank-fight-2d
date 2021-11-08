using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManagerPunktow : MonoBehaviour
{
    [SerializeField] int punkty;
    [SerializeField] TextMeshProUGUI punktyNaInterfejsie;
    
    private void Update() {
        punktyNaInterfejsie.text = punkty.ToString();
    }
     
    public void DodajPunkty(){
        punkty++;
        punktyNaInterfejsie.text = punkty.ToString();
    }
}
