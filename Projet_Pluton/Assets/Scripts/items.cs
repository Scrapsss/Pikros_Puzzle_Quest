using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class items : MonoBehaviour
{
    [SerializeField] private Text text_items;
    Dictionary<string,int> Items = new Dictionary<string,int>();    


    // Start is called before the first frame update
    void Start()
    {
        Items["Pikros"] = 0;
        Items["Cles"] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Afficher();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            GameManager.Instance.key++;
            GameObject objet_pris = other.gameObject;
            Destroy(objet_pris);

        }
    }

    private void Afficher()
    {
        Items["Cles"] = GameManager.Instance.key;


        string itemsText = "";
        foreach (string item in Items.Keys)
        {
            itemsText += item + " : " + Items[item] + "     " ;
        }
        text_items.text = itemsText;
    }

}
