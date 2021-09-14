using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class Example : MonoBehaviour
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
            "It is Certain",
            "It is decidedly so",
            "Without a doubt",
            "Yes definitely",
            "You may rely on it",
            "As I see it, yes",
            "Most likely",
            "Outlook good",
            "Yes",
            "Signs point to yes",
            "Reply hazy, try again",
            "Ask again later",
             "Better not tell you now",
             "Cannot predict now",
             "Concentrate and ask again",
             "Don't count on it",
             "My reply is no",
             "My sources say no",
             "Outlook not so good",
             "Very doubtful"
        };

        int randomPick = Random.Range(0, randomMysteryWord.Length);

        mysteryMessage.GetComponent<TextMeshPro>().text = randomMysteryWord[randomPick];

        return mysteryMessage.GetComponent<TextMeshPro>().text;
    }

    void Update()
    {




    }

};