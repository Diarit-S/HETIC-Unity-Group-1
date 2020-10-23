using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrementor : MonoBehaviour
{
    private Global GlobalRef;
    // Start is called before the first frame update
    void Start()
    {
        GlobalRef = GameObject.FindObjectOfType<Global>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncrementHandler() {

        GlobalRef.Coins++;

        if (GlobalRef.ScoreMultiplicator < 10 ) {
            if(GlobalRef.Coins % 100 == 0) {
                GlobalRef.ScoreMultiplicator += 0.5;
            }
        } 
    }
}
