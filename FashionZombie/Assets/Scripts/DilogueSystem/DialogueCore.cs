using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueCore : MonoBehaviour
{
    [SerializeField]private GameObject[] buttons;
    [SerializeField]private TextMeshProUGUI textComponent;
    [SerializeField]private string[] lines;
    [SerializeField]private float textSpeed;

    [SerializeField]private PlayerInputs inputs;

    private int index;

    private void Awake() {
        inputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();
    }
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        OnTyped();
    }

    void OnTyped()
    {
        if(textComponent.text == lines[index])
        {
            NextLine();
        }
        else if(inputs.mouseClick > 0 && textComponent.text != lines[index])
        {
            StopAllCoroutines();
            textComponent.text = lines[index];
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine("Typing");
    }

    IEnumerator Typing()
    {
        foreach(char c in lines[index].ToCharArray())
        {
        textComponent.text += c;
        yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine("Typing");
        }
        else
        {
            for(int i = 0; i < buttons.Length;i++)
            {
            buttons[i].SetActive(true);
            }
        }
    }
}
