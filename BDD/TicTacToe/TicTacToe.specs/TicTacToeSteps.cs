using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TicTacToe.Core;

namespace TicTacToe.specs
{
    [Binding]
    public class TicTacToeSteps
    {
        private string[,] _board;
        private string _result;
        private GameEngine _gameEngine = new GameEngine();

        [Given(@"I have a tic tac toe board")]
        public void GivenIHaveATicTacToeBoard()
        {
            _board = new String[3, 3] ;// {{" ", " ", " "}, {" ", " ", " "}, {" ", " ", " "}};
        }
        
        [Given(@"the board is empty")]
        public void GivenTheBoardIsEmpty()
        {
            _board = new String[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        }
        
        [When(@"I determine the winner")]
        public void WhenIDetermineTheWinner()
        {
            _result = _gameEngine.GetWinner(_board);
        }
        
        [Then(@"the result be a tie")]
        public void ThenTheResultBeATie()
        {
            Assert.AreEqual(" ", _result);
        }

        [Given(@"I have an '(.*)' in the top left")]
        public void GivenIHaveAnInTheTopLeft(string p0)
        {
            _board[0, 0] = p0;
        }

        [Given(@"I have an '(.*)' in the top middle")]
        public void GivenIHaveAnInTheTopMiddle(string p0)
        {
            _board[0, 1] = p0;
        }

        [Given(@"I have an '(.*)' in the top right")]
        public void GivenIHaveAnInTheTopRight(string p0)
        {
            _board[0, 2] = p0;
        }

        [Then(@"the result will be an '(.*)'")]
        public void ThenTheResultWillBeAn(string p0)
        {
            Assert.AreEqual(p0, _result);
        }

        [Given(@"the board looks like this")]
        public void GivenTheBoardLooksLikeThis(Table table)
        {
            _board[0, 0] = table.Rows[1]["col1"];
        }


    }
}
