using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _text;

    //public int score = 0;


    private void Awake()
    {

        _text.text = score.totalScore.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {

            score.totalScore++;
            _text.text = score.totalScore.ToString();
        }
    }
}
