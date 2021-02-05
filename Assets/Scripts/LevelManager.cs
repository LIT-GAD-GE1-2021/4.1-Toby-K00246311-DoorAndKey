using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    public GameObject door;
    public doorController doorCon;
    public float doorSpeed;
    public bool hasKey;

    private void Awake()
    {
        instance = this;
        doorSpeed = 0;
    }

   public void KeyCollected()
    {
        hasKey = true;

        Debug.Log("Key Collected");
    }

    public void UsedKey()
    {
        hasKey = false;

        doorSpeed = 20;
        doorCon.SetDoorSpeed(doorSpeed);
        
        Debug.Log("Key Used");
    }
    
}
