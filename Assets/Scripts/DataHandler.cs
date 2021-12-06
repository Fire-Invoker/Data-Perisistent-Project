using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataHandler : MonoBehaviour
{
    public static DataHandler Instance;

    public static int _score;
    public static int _highScore;
    public static int _currentHighScore;
    public Text _highScoreText;

    void Awake()
    {
        PersistHandler();
        _highScore = 0;
        _currentHighScore = 0;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateHighScore(int endScore)
    {
        if (endScore > _currentHighScore)
        {
            _currentHighScore = endScore;
        }
    }

    void PersistHandler()
    {
        DontDestroyOnLoad(gameObject);

        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }

        else
        {
            Instance = this;
        }
    }
}
