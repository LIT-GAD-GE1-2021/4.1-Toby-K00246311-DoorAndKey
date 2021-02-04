using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    public GameObject theCharacter;
    public GameObject theKey;
    public GameObject keyHole;
    public GameObject theDoor;

    private bool hasKey;

    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
    
}
