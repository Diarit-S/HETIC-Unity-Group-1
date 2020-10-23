using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBullet : MonoBehaviour
{
    public GameObject ObjPrefabs;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject spawnee = GameObject.Instantiate(ObjPrefabs);
            Vector3 spawnerPos = transform.position;
            spawnerPos.x += 0;
            spawnee.transform.position = spawnerPos;
        }
    }
}
