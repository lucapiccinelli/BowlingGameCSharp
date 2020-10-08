# Bowling Game with TDD, Incremental approach and Simple design

<img src=https://github.com/lucapiccinelli/BowlingGameCSharp/blob/master/bowling.png width=200px />

This is an implementation of the bowling game kata https://kata-log.rocks/bowling-game-kata. 

It is part of a **workshop** that I am proposing to help companies that **struggles in applying TDD**. **Slides** here https://docs.google.com/presentation/d/1yWMWz5MBmiapV_lftxF5UobUvvCB5EDAInaEc92ocPg/edit

## Goal

**The aim** of this implementations is to reach a **Simple design**, approaching the problem with the **Incremental approach**. **TDD** frameworks the resolution of the problem.

## Requirements

Beyond the tipical requirements of this kata, here it is required to **play the game from the console**: it takes input rolls from the command line, as a plain text list of numbers, and displays the outputs as follows:
 - TODO: Show the total score on the second line. Update the total score while running
 - TODO: Show the score by frame on the first line. Update the score only when the frame is closed. Otherwise show a "-"
 
 example:
 ```
 c:\> BowlingGame.exe 1 1 10 5 5 
 2 20 -
 32
 ```
 
 ## Branches:
  - **master**: this branch contains only the project files and `BowlingGameTests.cs` with the tests list of the first requirement (print the total score). It is a good basis to start from, if you like to have a try 😊.
  - **finished**: this is a complete implementation. Commits are (quite 😅) clean. In every commit there is an incremental step.
  - **anotherImplementation**: yet another implementation, similar to the other 😛
