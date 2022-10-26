using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomTasks : MonoBehaviour
{
    public TMP_Text inputText;
    public TMP_Text showingText;
    public TMP_InputField textToInput;

    [SerializeField] private string inputedText;

    public void PlayerInputText()
    {
        inputedText = inputText.text;
    }

    public void ShowUserText()
    {
        showingText.text = inputedText;
    }
}
