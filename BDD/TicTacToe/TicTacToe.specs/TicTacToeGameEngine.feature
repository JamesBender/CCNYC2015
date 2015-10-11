Feature: Tic Tac Toe
	In order to determine who the winner of the game as
	As a Player
	I want to be told who (if anyone) won the game

Scenario: Empty board ends with a tie
	Given I have a tic tac toe board
	And the board is empty
	When I determine the winner
	Then the result be a tie

Scenario: When X is accross the top then X wins
	Given I have a tic tac toe board
	And I have an 'X' in the top left
	And I have an 'X' in the top middle 
	And I have an 'X' in the top right
	When I determine the winner
	Then the result will be an 'X'

Scenario: When O is accross the top then O wins
	Given I have a tic tac toe board
	And I have an 'O' in the top left
	And I have an 'O' in the top middle
	And I have an 'O' in the top right
	When I determine the winner
	Then the result will be an 'O'

Scenario: When the board looks like this then someone wins
	Given I have a tic tac toe board
	And the board looks like this
	| col1 | col2 | col3 |
	| X    |      |      |
	| O    | O    | X    |
	| X    | O    |      |
	When I determine the winner
	Then the result be a tie