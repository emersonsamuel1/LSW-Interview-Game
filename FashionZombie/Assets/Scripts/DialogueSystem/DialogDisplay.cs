using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogDisplay : MonoBehaviour
{
    [SerializeField]private GameObject Options;
    public Conversation conversation;

    public GameObject speakerLeft;
    public GameObject speakerRight;

    private SpeakerUi speakerUiLeft;
    private SpeakerUi speakerUiRight;

    private int activeLineIndex = 0;

    private PlayerInputs playerInputs;
    bool canAdvance = true;

private float time;
    private void Awake() {
        playerInputs = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInputs>();

        speakerUiLeft = speakerLeft.GetComponent<SpeakerUi>();
        speakerUiRight = speakerRight.GetComponent<SpeakerUi>();

        speakerUiLeft.Speaker = conversation.speakerLeft;
        speakerUiRight.Speaker = conversation.speakerRight;
    }

    void Update()
    {
        if(playerInputs.mouseClick > 0 && time < Time.time)
        {
            playerInputs.DisableControlsLand();
            AdvanceConversation();
            time = Time.time + 0.5f;
            canAdvance = true;
        }
    }

    public void AdvanceConversationOnlyOnce()
        {
            if(canAdvance)
            {
                AdvanceConversation();
                canAdvance = false;
                time = Time.time + 0.5f;
            }
        }

    public void AdvanceConversation() 
    {
        if(activeLineIndex < conversation.lines.Length)
        {
            DisplayLine();
            activeLineIndex++;
        }
        else if(activeLineIndex == conversation.lines.Length)
        {
            Options.SetActive(true);
        }
        else if(activeLineIndex == conversation.lines.Length + 1)
        {
            Options.SetActive(false);
            playerInputs.EnableControlsLand();
            speakerUiLeft.Hide();
            speakerUiRight.Hide();
            activeLineIndex = 0;
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
        inactiveSpeakerUi.Hide();
    }

    public void OnLeave()
    {
        activeLineIndex++;
        AdvanceConversation();
    }
}
