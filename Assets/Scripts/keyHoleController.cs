using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyHoleController : MonoBehaviour
{
    private bool eDown;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            eDown = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && LevelManager.instance.hasKey == true && eDown == true)
        {
            LevelManager.instance.UsedKey();
        }
    }
}
