
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;
    bool collide=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //S
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag   ==  "Obstacle")
        {
           // movement.enabled =   false;
            collide=true;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    public bool collision()
    {
        return collide;
    }
}
