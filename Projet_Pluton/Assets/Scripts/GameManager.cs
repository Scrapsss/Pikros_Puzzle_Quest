using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _Instance;

    // On crée une variable publique Instance pour pouvoir accéder à la variable privée _Instance
    public static GameManager Instance
    {
        get
        {
            return _Instance;
        }
    }

    // On crée le patern singleton
    // Permettant d'accéder à un script à partir d'un autre script
    private void Awake()
    {
        // Si l'instance n'a pas été attribuée 
        if (_Instance == null)
        {
            _Instance = this;   // La variable _Instance = la classe GameManager
        }
        // Sinon
        else
        {
            Destroy(this);      // On la détruit si y'en a trop (car un singleton doit être unique)
        }
    }

    [Header("Objets du joueur")]
    // Objets du joueurs
    public int key = 0;         // Variable de clé possedés par le joueur 

}
