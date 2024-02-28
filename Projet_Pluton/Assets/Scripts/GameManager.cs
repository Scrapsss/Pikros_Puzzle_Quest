using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _Instance;

    // On cr�e une variable publique Instance pour pouvoir acc�der � la variable priv�e _Instance
    public static GameManager Instance
    {
        get
        {
            return _Instance;
        }
    }

    // On cr�e le patern singleton
    // Permettant d'acc�der � un script � partir d'un autre script
    private void Awake()
    {
        // Si l'instance n'a pas �t� attribu�e 
        if (_Instance == null)
        {
            _Instance = this;   // La variable _Instance = la classe GameManager
        }
        // Sinon
        else
        {
            Destroy(this);      // On la d�truit si y'en a trop (car un singleton doit �tre unique)
        }
    }

    [Header("Objets du joueur")]
    // Objets du joueurs
    public int key = 0;         // Variable de cl� possed�s par le joueur 

}
