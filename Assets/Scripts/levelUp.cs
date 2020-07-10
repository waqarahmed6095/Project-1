
using UnityEngine;

public class levelUp : MonoBehaviour
{
    bool hasCollided;
    bool hasFallen;
    float playerPosition;
    bool levelup=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hasFallen=FindObjectOfType<playerMovement>().fall();
        hasCollided=FindObjectOfType<playerCollision>().collision();
        playerPosition=FindObjectOfType<playerMovement>().transform.position.z;
        // level is completed if object not fallen,collided and it passed last object
        if (!hasCollided && !hasFallen )
        {
            if(playerPosition>transform.position.z)
            {
                levelup=true;
            }
        }

    }
    public bool levelCompleted(){
        return levelup;
    }
}
