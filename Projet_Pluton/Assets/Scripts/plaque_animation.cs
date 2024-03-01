using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaque_animation : MonoBehaviour
{


    // On creer un dictionnaire contenant les interrupteurs necessaires pour ouvrir la porte. (True : activé, false : pas activé)
    public Dictionary<GameObject, bool> interrupteurs = new Dictionary<GameObject, bool>();
    public List<GameObject> cle_interrupteur = new List<GameObject>();

    public GameObject Porte;
    public Vector3 deplacementPorte;

    public Vector3 bouton_active;

    // active = si tous les interrupteur sont activés
    private bool active = false;
    private float speed = 1;
    private Vector3 position_depart;

     void Start() 
    {
        // On initialise l'emplacement de départ de la porte
        position_depart = Porte.transform.position;

        // On initialise les interrupteurs du dictionnaire à false (pas activés) :
        foreach (GameObject cle in cle_interrupteur)
        {
            interrupteurs[cle] = false;
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        // Si tous les interrupteur ne sont pas activés :
        if (!active)
        {
            // On vérifie si le dictionnaire contient l'interrupteur avec lequel on est entré en collision :
            if (interrupteurs.ContainsKey(this.gameObject))
            {
                // On active l'interrupteur correspondant
                interrupteurs[this.gameObject] = true;
            }
        }

        foreach (GameObject interr in interrupteurs.Keys)
        {
            Debug.Log("le dictionnaire : " + interr + " : " + interrupteurs[interr]);
        }
        

    }


    void Update() 
    {

        // On vérifie si tous les interrupteurs sont activés :
        foreach (GameObject interrupteur in interrupteurs.Keys)
        {
            if (interrupteurs[interrupteur] == false)
            {
                break;
            }
            else
            {
                active = true;
            }
        }





        if (active) 
        {
            if (Porte.transform.position != position_depart + deplacementPorte )
            {
                Porte.transform.position = Vector3.MoveTowards(Porte.transform.position, position_depart + deplacementPorte, speed * Time.deltaTime);
            }
        }

       
    }



}

