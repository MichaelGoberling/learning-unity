using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    enum Screen { MainMenu, Password, Win };

    int level;
    Screen currentScreen = Screen.MainMenu;

	// Use this for initialization
	void Start ()
    {
        ShowMainMenu();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void ShowMainMenu()
    {
        string[] placesToHackInto = new string[] { "Small Lot", "White House", "Google" };

        Terminal.ClearScreen();
        Terminal.WriteLine("What place would you like to hack into?");
        PrintHackingPlaceOptions(placesToHackInto);
        Terminal.WriteLine("\nEnter your selection here:");
    }

    // Clears the terminal screen and prints the initial options for places to hack into 
    void PrintHackingPlaceOptions(string[] placesToHackInto)
    {
        int controlKey = 1;
        foreach (string place in placesToHackInto) {
            PrintHackingPlaceOption(controlKey, place);
            controlKey++;
        }
    }

    // Takes a control key and place and prints it to the terminal telling the user to press it as
    // an option
    void PrintHackingPlaceOption(int controlKey, string place)
    {
        Terminal.WriteLine("Press " + controlKey + " to hack into " + place);
    }

    // When the user preses enter while focused on the terminal, the characters they entered will 
    // come here
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "420")
        {
            Terminal.WriteLine("Smoke weed every day!");
        }
        else if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have selected level " + level);
        Terminal.WriteLine("Please enter your password: ");
    }
}
