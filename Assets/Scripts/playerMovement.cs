
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
   //sideway force (to move in x direction)
    public float sidewaysForce   =   20f;
    //initial z poistion
    float initialz=0f;
    public Transform player;
    // Start is called before the first frame update
    bool stageIndicator=false;
    void Start()
    {
        //position of player in z direction when game level is started
        initialz= player.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        // move in positive x direction
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        //move in negative x direction
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        //player fall from the ground
        if(rb.position.y<-1f)
        {
            stageIndicator=true;
            
            FindObjectOfType<GameManager>().EndGame();
            
        }

        //change in z direction noticed if collided directly, threshold is 1f
        if (player.position.z-initialz>0.2f)
        {
            
            
            
           stageIndicator=true;
            
           FindObjectOfType<GameManager>().EndGame();
        }


    }
    // Does the object fall from the ground
    public bool fall()
    {
        return stageIndicator;
    }
}
