using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_recinto : MonoBehaviour {

    public float speed = 10.0f;
    public float amax = 3.5f;

    private Rigidbody body;

	// Use this for initialization
	void Start () {
	}

    void Awake()
    {
        body = gameObject.GetComponent<Rigidbody>();		
    }

     

	// Update is called once per frame
	void Update () {
        Vector3 pos = body.position;
        
      if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y = pos.y + speed * Time.deltaTime;
        }
      if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y = pos.y - speed * Time.deltaTime;
        }

        body.MovePosition(pos);
    
	}
}


