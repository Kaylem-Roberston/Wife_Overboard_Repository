using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using TMPro;


public class GameManager : MonoBehaviour

{

    public TMP_Text healthTxt;

    public PlayerController playerController;


  


    private void Start()

    {

        float health = playerController.health;

        healthTxt.text = "Score: " + health;


    }

    private void Update()
    {

        float health = playerController.health;
    }

    public void ItemCollected()

    {

     

    }

}