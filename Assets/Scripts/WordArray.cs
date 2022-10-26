using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordArray : MonoBehaviour
{
    public string[] taskArray;
    public int arrayLength;
    public int lengthNumber;
    [SerializeField] private TMP_Text TextOutput;
    
    
    private void Start()
    {

        
        string[] taskArray =
        {
            
            "Find a Jack-O-Lantern and take a picture of it",
            "Take a picture of a spider",
            "Draw a witch's hat",
            "Make a mask and take a picture in it",
            "Make a ghost with toilet paper",
            "Make a mummy with toilet paper",
            "Take a picture of a Black Cat",
            "Scream 'Boo!'",
            "Dress your Pet a Halloween costume",
            "Dance the Monster Dance",
            "Draw a skeleton",
            "Draw a bat",
            "Draw a hat",
            "Draw a skeleton",
            "Draw a spider",
            "Draw Jack-o-Lantern",
            "Draw a ghost",
            "Draw a monster",
            "Name 3 Halloween words",
            "Name 3 scary things",
            "Name 3 black things",
            "Find 2 hats",
            "Find a pumpkin",
            "Say 'Trick or Treat!'",
            "Say 'Jack-o-Lantern'",
            "Spell the word 'mummy'",
            "Spell the word 'vampire'",
            "Spell the word 'witch'",
            "Spell the word 'pumpkin'",
            "Take a photo of a black cat",
            "Take a photo of a pumpkin",
            "Take a photo of Jack-o-Lantern",
            "Say a rhyme for A BAT",
            "Make a Jack-o-Lantern out of a fruit",
            "Answer - When is Halloween?",

        };
        lengthNumber = Random.Range(0, taskArray.Length);
        Debug.Log(taskArray.Length);

        arrayLength = taskArray.Length;
    }
    private void FixedUpdate()
    {

      

        string[] taskArray =
        {
            "Find a Jack-O-Lantern and take a picture of it",
            "Take a picture of a spider",
            "Draw a witch's hat",
            "Make a mask and take a picture in it",
            "Make a ghost with toilet paper",
            "Make a mummy with toilet paper",
            "Take a picture of a Black Cat",
            "Scream 'Boo!'",
            "Dress your Pet a Halloween costume",
            "Dance the Monster Dance",
            "Draw a skeleton",
            "Draw a bat",
            "Draw a hat",
            "Draw a skeleton",
            "Draw a spider",
            "Draw Jack-o-Lantern",
            "Draw a ghost",
            "Draw a monster",
            "Name 3 Halloween words",
            "Name 3 scary things",
            "Name 3 black things",
            "Find 2 hats",
            "Find a pumpkin",
            "Say 'Trick or Treat!'",
            "Say 'Jack-o-Lantern'",
            "Spell the word 'mummy'",
            "Spell the word 'vampire'",
            "Spell the word 'witch'",
            "Spell the word 'pumpkin'",
            "Take a photo of a black cat",
            "Take a photo of a pumpkin",
            "Take a photo of Jack-o-Lantern",
            "Say a rhyme for A BAT",
            "Make a Jack-o-Lantern out of a fruit",
            "Answer - When is Halloween?",
        };

        TextOutput.text = taskArray[lengthNumber];
    }


}
