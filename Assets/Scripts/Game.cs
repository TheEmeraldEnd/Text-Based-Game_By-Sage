using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] Text textElement;
    [SerializeField] State startState;
    State state;

    [SerializeField] Text titleCard;
    bool titleGone = false;

    // Start is called before the first frame update
    void Start()
    {
        state = startState;
        textElement.text = state.GetStateText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1") && titleGone == false)
        {
            RidTitle();
        }

        if (titleGone == true)
        {
            GameMain();
        }
    }


    //User input portion
    private void GameMain()
    {
        State[] statesArray = state.GetOtherState();
        //Note: this for loop allows me to put in the amount of states
        //there are.
        for (int i = 0; i <= state.GetArayAmount(); i++)
        {
            if (Input.GetKeyDown($"{i}"))
            {
                state = statesArray[i - 1];
            }
        }
        textElement.text = state.GetStateText();



    }

    //Gets rid of the title
    public void RidTitle()
    {
        titleCard.text = "";
        titleGone = true;

        textElement.alignment = TextAnchor.MiddleLeft;

    }

}