using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text buttonText;
    public AudioSource placeDown;

    private GameController gameController;

    public void Start()
    {
        placeDown = GetComponent<AudioSource>();
    }

    public void SetGameControllerReference (GameController controller)
    {
        gameController = controller;
    }

    public void SetSpace()
    {
        buttonText.text = gameController.setPlayerSide();
       placeDown.Play(0);
        button.interactable = false;
        gameController.EndTurn();
    }
}
