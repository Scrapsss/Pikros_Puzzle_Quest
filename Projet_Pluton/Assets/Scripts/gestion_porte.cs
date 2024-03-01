using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestion_porte : MonoBehaviour
{

    // On creer un dictionnaire contenant les interrupteurs necessaires pour ouvrir la porte. (True : activé, false : pas activé)
    public Dictionary<GameObject, bool> interrupteurs = new Dictionary<GameObject, bool>();
    public List<GameObject> cle_interrupteur = new List<GameObject>();
    private bool active_door = false;

    public Vector3 deplacementPorte;
    private float speed = 1;
    private Vector3 position_depart;



    // Start is called before the first frame update
    void Start()
    {
        // On initialise l'emplacement de départ de la porte
        position_depart = this.transform.position;

        foreach (GameObject cle_int in cle_interrupteur)
        {
            interrupteurs.Add(cle_int, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (active_door)
        {
            if (this.transform.position != position_depart + deplacementPorte)
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, position_depart + deplacementPorte, speed * Time.deltaTime);
            }
        }
    }
    
    public void miseAJour (GameObject interrupteur, bool isactive)
    {

        if (interrupteurs.ContainsKey(interrupteur))
        {
            interrupteurs[interrupteur] = isactive;
        }

        if (!active_door)
        {
            active_door = CanOpenDoor(interrupteurs);
        }

    }

    private bool CanOpenDoor (Dictionary<GameObject,bool> interrupteurs)
    {
        
        foreach (bool valeur in interrupteurs.Values)
        {
            if (!valeur)
            {
                return false;
            }
        }
        return true;
    }
}
