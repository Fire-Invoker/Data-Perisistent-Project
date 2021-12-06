using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    public int bestScore;
    public string bestPlayerName;
    public TMP_InputField input;

    // Start is called before the first frame update
    void Start()
    {
        MenuManager.Instance.LoadBestPlay();

        bestPlayerName = MenuManager.Instance.bestPlayerName;
        bestScore = MenuManager.Instance.bestScore;

        if (bestScore != 0)
        {
            bestScoreText.text = "Best Score: " + bestScore;
            input.text = MenuManager.Instance.bestPlayerName;
        }

    }

    public void StartGame()
    {
        MenuManager.Instance.playerName = input.text;
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        MenuManager.Instance.SaveBestPlay();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif        
    }
}