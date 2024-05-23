using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool timer = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer)
        {
            timer = false;
            Invoke("setTimer", 1.0f);
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
    void setTimer()
    {
        timer = true;
    }
}
