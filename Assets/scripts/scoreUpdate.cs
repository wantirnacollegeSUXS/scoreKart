using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using static UnityEngine.PlayerLoop.EarlyUpdate;

public class scoreUpdate : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText; // Assign this in the Inspector
    public TextMeshProUGUI GameOverText;
    public Button Restartbutton;
    public TextMeshProUGUI finalscore;
    public Button start;
    public TextMeshProUGUI titlecard;
    public TextMeshProUGUI carhit;

    void Start()
    {
        score = 0;
        UpdateScore(0);
        start.onClick.AddListener(startgame);
    }
    void Update()
    {
        
    }
    public void minus(int scoreToAdd) 
    {
    score -= scoreToAdd;
    
    }
    void startgame() 
    {
        
        titlecard.gameObject.SetActive(false);
        start.gameObject.SetActive(false);
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
        finalscore.text = "wow thats awason that awson: " + score;
    }
    public void GameOver()
    { 
    GameOverText.gameObject.SetActive(true);
    Restartbutton.gameObject.SetActive(true);
    finalscore.gameObject.SetActive(true);
    
    
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ifcarhit() 
    {
    carhit.gameObject.SetActive(true);
    }
    
}

// Update is called once per frame


