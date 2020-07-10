
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameEnded=false;
    public float delay=2f;
    bool level1Completed=false;
    public GameObject completeLevelUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        level1Completed=FindObjectOfType<levelUp>().levelCompleted();
        if (level1Completed)
        {
            completeLevelUI.SetActive(true);
            gameEnded=true;
            Invoke("Restart",delay );
        }
        
    }
    
    public void EndGame()
    {
        if (!gameEnded)
        {
            gameEnded=true;
            Invoke("Restart",delay );
        }
    }
    void   Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
