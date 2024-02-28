using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prison : MonoBehaviour
{
    
    [SerializeField]private GameObject image_prison;
    [SerializeField] private Text texte_prison;
    private bool est_dans_la_zone = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            texte_prison.GetComponent<Text>().color = Color.white;
            texte_prison.text = "Appuyez sur 'O' pour ouvrir la prison.";
            image_prison.gameObject.SetActive(true);
            est_dans_la_zone=true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            image_prison.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (!est_dans_la_zone)
        {
            image_prison.gameObject.SetActive(false);
        }
   
        if (Input.GetKey(KeyCode.O))
        {
            if (est_dans_la_zone)
            {
                if (GameManager.Instance.key>0)
                {
                    
                    iTween.ShakeScale(this.gameObject, new Vector3(0.4f, 0.4f, 0.4f), 0.5f);
                    GameManager.Instance.key--;
                    Destroy(this.gameObject,0.7f);
                }
                else
                {
                    texte_prison.text = "Il vous manque une clé.";
                    texte_prison.GetComponent<Text>().color = Color.red;
                    StartCoroutine("text_Delay");
                }
            }
        }
    }

    IEnumerator text_Delay()
    {
        yield return new WaitForSeconds(3);
        image_prison.SetActive(false);
    }


}
