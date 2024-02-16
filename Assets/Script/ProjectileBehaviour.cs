using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float Speed = 4;
    public bool thrown;
    public Vector 3 LaunchOffset;


    // Start is called before the first frame update
    void Start()
    {
        var direction = -transform right;
        GetComponent<Rigidbody2D>.AddForce(direction * Speed,ForceMode2D.Impulse);
        Destroy(GameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
