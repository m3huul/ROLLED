using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;
    public GameObject Text;
    void Start()
    {
        Text.SetActive(true);
    }
    void Update()
    {
        ScoreText.text = Player.position.z.ToString("0");
    }
}
