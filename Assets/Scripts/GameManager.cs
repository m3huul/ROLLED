using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float RestartGame;
    public GameObject Player;
    public GameObject Panel;
    public void Update()
    {
        if (Player.transform.position.y<-1)
        {
            GameEnded();
        }
    }
    public void LevelComplete()
    {
        Panel.SetActive(true);
    }
    public void GameEnded()
    {
        Invoke("Restart",RestartGame);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
