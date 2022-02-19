using UnityEngine;
using UnityEngine.SceneManagement;

//Deals with the game when the player loses all of their lives and display the final results before moving back to the menu
public class GameManager : MonoBehaviour
{

    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ScoreSystem.Lives == 0)
        {
            EndGame();
        }
    }
    public void EndGame()
    {
        Debug.Log("Game Over");
        panel.SetActive(true);
        //delays the game from moving between scenes too fast
        Invoke("Restart", 5f);

    }
    //Switches Scenes
    void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
