using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameStart;
    public Block[] blocks;
    public GameObject GameOverUI;
    public AudioClip sound1;
    AudioSource audioSource;
    public GameObject bgm;


    private bool isGameClear = false;
    // Start is called before the first frame update
    void Start()
    {
        isGameStart = false;
        audioSource = GetComponent<AudioSource>();
        
    }

    public void GameOver()
    {
        audioSource.PlayOneShot(sound1);
        bgm.SetActive(false);
        GameOverUI.SetActive(true);
        Debug.Log("ゲームオーバー");
    }
    public void GameRetry()
    {
        SceneManager.LoadScene("game");
    }
}
