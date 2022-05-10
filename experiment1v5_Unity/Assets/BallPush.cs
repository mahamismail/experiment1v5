using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPush : MonoBehaviour
{   
    public KeyCode ballUp = KeyCode.Space;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            float rand = Random.Range(0,1);
            if (Input.GetKey(ballUp)) {
                rb2d.AddForce(new Vector2(0, 1));
            }
        
    }
}
