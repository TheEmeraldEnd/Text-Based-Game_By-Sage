using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] string gameText;
    [SerializeField] State[] otherStates;
    //[SerializeField] List<string> choiceText;



    // Returns game text
    public string GetStateText()
    {
        return gameText;
    }

    // return other possible states
    public State[] GetOtherState()
    {
        return otherStates;
    }

    //return state arrays
    public int GetArayAmount()
    {
        return otherStates.Length;
    }


    //This was my graveyard of trying to get the state to display the options
    //vertically. History museum (Note this doesn't include the things in
    //main game, but gives part of an insight into what I was trying to accomplish
    //return choice text
    //@int i (the parameter choosing the choice text in the list.
    //public string GetTextListChoices(int i)
    //{
    //    return choiceText[i];
    //}

    //public int GetTextChoiceArrayAmount()
    //{
    //    return choiceText.Count;
    //}


    //public void CombineText(string newText)
    //{
    //    gameText += ("/n" + newText);
    //}


}
