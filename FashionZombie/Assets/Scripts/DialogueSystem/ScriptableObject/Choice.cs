using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Option
{
    [TextArea(2,5)]
    public string text;
    public Conversation conversation;
}



[CreateAssetMenu(fileName = "New Choice", menuName = "Choice")]
public class Choice : ScriptableObject
{
    [TextArea(2,5)]
    public string text;
    public Option[] choices;

}
