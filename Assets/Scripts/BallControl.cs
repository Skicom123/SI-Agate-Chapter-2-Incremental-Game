using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallControl : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;

    // Besarnya gaya awal yang diberikan untuk mendorong bola
    public float xInitialForce;
    public float yInitialForce;
    public float x;
    public float y;
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(-2f, 2f);
        y = Random.Range(-2f, 2f);
        pos = new Vector2(x, y);
        transform.position = pos;
        rigidBody2D = GetComponent<Rigidbody2D>();
        Invoke("PushBall", 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PushBall()
    {
        // Tentukan nilai komponen y dari gaya dorong antara -yInitialForce dan yInitialForce
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        // Tentukan nilai acak antara 0 (inklusif) dan 2 (eksklusif)
        float randomDirection = Random.Range(0, 2);

        // Jika nilainya di bawah 1, bola bergerak ke kiri. 
        // Jika tidak, bola bergerak ke kanan.
        if (randomDirection < 1.0f)
        {
            // Gunakan gaya untuk menggerakkan bola ini.
            rigidBody2D.AddForce(new Vector2(-xInitialForce, yRandomInitialForce));
        }
        else
        {
            rigidBody2D.AddForce(new Vector2(xInitialForce, yRandomInitialForce));
        }
    }
}
