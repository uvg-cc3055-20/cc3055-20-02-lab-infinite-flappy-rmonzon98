using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCrollingBackground : MonoBehaviour {
           
    public static float scrollingSpeed = 7f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!GameController.instance.gameOver) {
            transform.Translate(new Vector2(-0.5f, 0) * scrollingSpeed * Time.deltaTime);
            if (transform.position.x < -23.9)
            {
                transform.position = new Vector3(24f, transform.position.y, transform.position.z);
            }
        }

    }
}
