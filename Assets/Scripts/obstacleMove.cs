
using UnityEngine;

public class obstacleMove : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce   =   2000f;
    public float sidewaysForce   =   500f;
    // Start is called before the first frame update
    void Start()
    {
        forwardForce   =   500f;
    }

    // Update is called once per frame
    void Update()
    {
        //moving obstacle toward player
         rb.AddForce(0,0,-forwardForce*Time.deltaTime);
    }
}
