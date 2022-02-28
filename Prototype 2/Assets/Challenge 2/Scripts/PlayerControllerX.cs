using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 3;

    void start() 
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space)&& timer<=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 3;
        }
    }
}
