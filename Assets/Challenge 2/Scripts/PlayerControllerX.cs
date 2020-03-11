using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float lastPress = -0.5f;
    public float dogsPerSecond = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastPress > dogsPerSecond)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastPress = Time.time;
        }
    }
}
