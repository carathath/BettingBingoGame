# BettingBingoGame

#### This C# Windows Form was created in Microsot Visual Studio
#### **In order to run, you will also need the "BettingBingoGame_Library" code found here: https://github.com/carathath/BettingBingoGame_Library
This library is used in the "References" section in the *Solution Explorer* on Microsoft Visual Studio

This Betting Bingo Game is made to simulate a Bingo game board. It is made up of **FOUR** forms that will be described below

## Form1 - User Login/Sign Up
Form1 is the Login page for the user. They are given two options:
* Sign in with an existing account
  * If the user inputs incorrect credentials, the form will let them know with a pop up message.
  * If the credentials match, the user will be taken to **Form2**
* Sign up for a new account
  * When clicked, the user will be taken to **Form3**

## Form2 - Game Board
Form2, when viewed in its [Design] format, contains more that the user sees when the program is run. The different options available on the game board are as follows:
* Bet Amount
  * The user must input their bet amount before the game can start
  * The amount must be valid and not exceed more than their shown balance on the top left of the form
* Number of Moves
  * The user is met with a number box that will be a factor as a modifier of prize money won if they achieve Bingo
* Begin
  * Once both the **Bet Amount** and **Number of Moves** have valid values, the user is able to begin the game
  * The program makes a call to the library in order to fill the board with values
* Edit Account
  * When clicked, the user is met with **Form4**
* How to Play
  * The user is met with a pop-up window that describes how to use the game board
* Next Play
  * The user will need to click this button to get a new letter and number combination to be matched on their board
  * This value appears under the "Current Play" title
* Play Again/Exit Game
  * These two options become available once the user successfully finished their game or they run out of moves
  * Play Again allows the user to load up a new game board ans start again
  * Exit Game closes the application

## Form3 - New Account Interface
The user is met with 7 fields to be filled. These fields, if filled in correctly, get sent to the database in the library, to be added. If they are filled in incorrectly, the library returns an error code to be displayed as a pop-up message box. The fields are:
1. Username
1. Password
1. First Name
1. Last Name
1. Card Number
1. CVV
1. Starting Balance

## Form4 - Edit Account
When opened, the form contains the same fields as in **Form3** but have the user information already in them. Once the user clicks on "Update Account", the library will do its job to check ofr correct inputs.
