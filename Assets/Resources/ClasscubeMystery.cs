using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class ClasscubeMystery : MonoBehaviour
{

    public GameObject mysteryMessage;
    

    void Start()
    {
        //Text sets your text to say this message
        displayText();
    }

    String displayText()
    {
        string[] randomMysteryWord = {
            "Absolutey!",
            "Don't even sweat it",
            "Yes, if you stop shaking me so much",
            "How about you ask later",
            "No way in hell",
            "Don't even think about it",
            "Ask me more confidently",
            "100%",
            "What did you ask?", 
            "I wouldn't be so confident"
        };

        int randomPick = Random.Range(0, randomMysteryWord.Length);

        mysteryMessage.GetComponent<TextMeshPro>().text = randomMysteryWord[randomPick];

        return mysteryMessage.GetComponent<TextMeshPro>().text;
    }

    void Update()
    {




    }

};