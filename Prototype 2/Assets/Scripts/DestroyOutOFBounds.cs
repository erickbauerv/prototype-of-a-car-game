using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class DestroyOutOFBounds : MonoBehaviour {
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float leftBound = 30;
    private float rightBound = -30;
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update() {
        //Drestoy GameObject that are out of the scene view
        if(transform.position.z > topBound) {
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound) {
            Destroy(gameObject);
            
        } else if(transform.position.x > leftBound) {
            Destroy(gameObject);
            
        } else if(transform.position.x < rightBound) {
            Destroy(gameObject);
            
        }
    }
}
