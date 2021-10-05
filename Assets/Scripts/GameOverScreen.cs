using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Button _quitButton;
    [SerializeField] private Button _retryButton;
    [SerializeField] private Player _player;

    private CanvasGroup _gameOverCanvasGroup;

    private void OnEnable()
    {
        _player.PlayerDied += OnPlayerDied;
    }
    private void OnDisable()
    {
        _player.PlayerDied -= OnPlayerDied;
    }
    private void Start()
    {
        _gameOverCanvasGroup = GetComponent<CanvasGroup>();
        _gameOverCanvasGroup.alpha = 0;
        _retryButton.onClick.AddListener(OnRetryButtonClick);
        _quitButton.onClick.AddListener(OnQuitButtonClick);
    }

    private void OnPlayerDied()
    {
        _gameOverCanvasGroup.alpha = 1;
        Time.timeScale = 0;
    }

    private void OnRetryButtonClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    private void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
