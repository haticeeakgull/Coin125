using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class RestartGame : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene(0);
        score.totalScore = 0;
        

        
    }
}
