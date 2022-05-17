using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BOGameManager : MonoBehaviour
{
    public Ball ball { get; private set; }
    public Paddle paddle { get; private set; }
    public Brick[] bricks { get; private set; }

    const int NUM_LEVELS = 1;

    public int level = 1;
    public int score = 0;
    public int lives = 3;

    public AudioSource brickSource;
    public AudioClip[] brickSounds;
    public Text scoreText;
    public Text winText;
    public bool youWin;
    public float duration;

    public GameObject GM;
    public GameManager GMM;

    private void Start()
    {
        NewGame();
        duration = 5.0f;
        GM = GameObject.FindGameObjectWithTag("GameManager");
        GMM = GM.GetComponent<GameManager>();

    }
    private void Update()
    {
        if(youWin == true)
        {
            
            if (duration < 0.0f)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                duration = duration - Time.deltaTime;
            }
        }
    }

    private void NewGame()
    {
        score = 0;
        lives = 3;
        ball = FindObjectOfType<Ball>();
        paddle = FindObjectOfType<Paddle>();
        bricks = FindObjectsOfType<Brick>();

    }

    private void LoadLevel(int level)
    {
        this.level = level;

        if (level > NUM_LEVELS)
        {
            LoadLevel(2);
            return;
        }

        SceneManager.LoadScene("Level" + level);
    }



    public void Miss()
    {
        lives--;

        if (lives > 0) {
            ResetLevel();
        } else {
            GameOver();
        }
    }

    private void ResetLevel()
    {
        paddle.ResetPaddle();
        ball.ResetBall();
    }

    private void GameOver()
    {
        LoadLevel(1);
    }

    public void Hit(Brick brick)
    {
        score += brick.points;
        brickSource.clip = brickSounds[Random.Range(0, brickSounds.Length)];
        brickSource.Play();
        scoreText.text = "score " + score.ToString();
        if (Cleared()) {
            YouWin();
        }
    }

    private bool Cleared()
    {
        for (int i = 0; i < bricks.Length; i++)
        {
            if (bricks[i].gameObject.activeInHierarchy && !bricks[i].unbreakable) {
                return false;
            }
        }

        return true;
    }

    void YouWin()
    {
        winText.text = "You Win! Your score is " + score.ToString() + " Look Out Behind You!";
        GMM.breakoutWin = true;
        youWin = true;
        GameObject GM = GameObject.Find("GameManager");
        GameManager G = GM.GetComponent<GameManager>();
        G.breakoutWin = true;
        G.relicsToSpawn += 1;
    }

}
