
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    int count=0;
    public Text scoreText;
    bool hasCollided;
    bool hasFallen;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        hasFallen=FindObjectOfType<playerMovement>().fall();
        hasCollided=FindObjectOfType<playerCollision>().collision();
        //update score if not collided or not fallen
        if (!hasCollided && !hasFallen )
        {
            count++;
        }
        scoreText.text= ""+count;
        
    }
    
   
}
