using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{ public int[] GeneraArray()
    { int[] nuovo = new int[20];
        for (int i = 0; i < nuovo.Length; i++)
        { nuovo[i] = Random.Range(1, 21); } return nuovo;

    }
    public int SommaArray(int[] nuovo)
    { int somma = 0; for (int i = 0; i < nuovo.Length; i++)
        { somma += nuovo[i]; }
        return somma;

    }
    void StampaArray(int[] giammarco) { for (int i = 0; i < giammarco.Length; i++)
        { Debug.Log("l'elemento " + i + " è: " + giammarco[i]); }
        } 

     // Start is called before the first frame update
    void Start()
    {
       int[] filippo = GeneraArray();
       int somma = SommaArray(filippo);
        Debug.Log("somma:" + somma);
        StampaArray(filippo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
