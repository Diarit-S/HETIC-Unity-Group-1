using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjects : MonoBehaviour
{
    public GameObject[] ObjPrefabs;

    public float Interval = 1;
    float TempsPasse = 0;

    public int Min = -1;
    public int Max = 2;

    public Proba[] probas;

    [System.Serializable]
    public class Proba
    {
        public GameObject Prefab;
        public int Amount;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TempsPasse += Time.deltaTime;

        if (TempsPasse > Interval)
        {
            //Prendre un objet au hasard
            int index = Random.Range(0, ObjPrefabs.Length);

            //Créer une instance/copie de l'objet prefab passé
            GameObject spawnee = GameObject.Instantiate(ObjPrefabs[index]);

            //récupérer position du spawner
            Vector3 spawnerPos = transform.position;

            //+= au lieu de = pour que le range soit relative à la position initiale du spawner
            spawnerPos.x += Random.Range(Min, Max);

            spawnee.transform.position = spawnerPos;

            TempsPasse = 0;
        }

    }
}