using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreValueScript : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("SavedScope"))
        {
            GetComponent<Text>().text = PlayerPrefs.GetInt("SavedScope").ToString();
        }
    }
}
