using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio7 : MonoBehaviour
{
     
    void GeneraArray(int[] dimensione, int minimo, int massimo)
    {
       
        for (int i = 0; i < dimensione.Length; i++)
        { dimensione[i] = Random.Range(minimo, massimo + 1); }
       
    }
     public int SommaArray(int[] nuovo)
    {
        int somma = 0; for (int i = 0; i < nuovo.Length; i++)
        { somma += nuovo[i]; }
        return somma;

    }
    void StampaArray(int[] giammarco)
    {
        for (int i = 0; i < giammarco.Length; i++)
        { Debug.Log("l'elemento " + i + " è: " + giammarco[i]); }
    }

    // Start is called before the first frame update
    void Start()
    {
        int[] filippo = new int[30];
            GeneraArray(filippo, 1, 100);
        int somma = SommaArray(filippo);
        Debug.Log("somma:" + somma);
        StampaArray(filippo);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

