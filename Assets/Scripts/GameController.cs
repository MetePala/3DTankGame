using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] 
    
    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
