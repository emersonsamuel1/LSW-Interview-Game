using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogDisplay : MonoBehaviour
{
    public Conversation conversation;

    public GameObject speakerLeft;
    public GameObject speakerRight;

    private SpeakerUi speakerUiLeft;
    private SpeakerUi speakerUiRight;

    private int activeLineIndex = 0;

    private void Awake() {
        speakerUiLeft = speakerLeft.GetComponent<SpeakerUi>();
        speakerUiRight = speakerRight.GetComponent<SpeakerUi>();

        speakerUiLeft.Speaker = conversation.speakerLeft;
        speakerUiRight.Speaker = conversation.speakerRight;
    }

    void Update()
    {

    }

    void AdvanceConversation()
    {
        if(activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex++;
        }
        else
        {
            speakerUiLeft.Hide();
            speakerUiRight.Hide();
        }
    }

    void DisplayLine()
    {
        Line line = conversation.lines[activeLineIndex];
        Character character = line.character;

        if(speakerUiLeft.SpeakerIs(character))
        {
            SetDialog(speakerUiLeft,speakerUiRight,line.text);
        }
        else
        {
            SetDialog(speakerUiRight,speakerUiLeft, line.text);
        }
    }

    void SetDialog(SpeakerUi activeSpeakerUi,SpeakerUi inactiveSpeakerUi,string text)
    {
        activeSpeakerUi.Dialog = text;  
        activeSpeakerUi.Show();
    }
}
