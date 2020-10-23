using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnerObjects : MonoBehaviour
{
    public Proba[] ProbasOptions;
    int Sum = 0;

    public float Interval = 1;
    float TempsPasse = 0;

    public int Min = -1;
    public int Max = 2;

    [System.Serializable]
    public class Proba
    {
        public GameObject ObjPrefab;
        public int Amount;
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach(Proba p in ProbasOptions) {
            Sum += p.Amount;
        }
    }


    // Update is called once per frame
    void Update()
    {   
        TempsPasse += Time.deltaTime;

        if (TempsPasse > Interval)
        {
            Proba choix = null;

            // int index = 0;
            int prob = Random.Range(0, Sum);

            int cum = 0;
            foreach(Proba p in ProbasOptions) {
                cum += p.Amount;
                if (prob < cum) {
                    choix = p;
                // Debug.Log(choix.ObjPrefab);
                    break;
                }
            }
            // Prendre un objet au hasard
            // int index = Random.Range(0, choix.ObjPrefab);

            //Créer une instance/copie de l'objet prefab passé
            GameObject spawnee = GameObject.Instantiate(choix.ObjPrefab);

            //récupérer position du spawner
            Vector3 spawnerPos = transform.position;

            //+= au lieu de = pour que le range soit relative à la position initiale du spawner
            spawnerPos.x += Random.Range(Min, Max);

            spawnee.transform.position = spawnerPos;

            TempsPasse = 0;
        }

    }
}