using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Tictactoe
    {
        public string[,] saBoard = new string[,] { { "0", "0", "0" } , { "0", "0", "0" } , { "0", "0", "0" } };
        public string winningLine;
        public winningMove eWinningMove;
        
        public enum winningMove
        {
            Row1,
            Row2,
            Row3,
            Col1,
            Col2,
            Col3,
            Diag1,
            Diag2
        }


        /// <summary>
        /// Definition of winning
        /// </summary>
        public bool IsWinningMove()
        {
            if (IsHorWin())
                return true;
            else if (IsVerWin())
                return true;
            else if (IsDiagonalwWin())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Definition of Tie
        /// </summary>
        public bool IsTie()
        {
            if (!IsWinningMove())
                return true;
            else
                return false;
        }


        /// <summary>
        /// Definition of Diagonal Win
        /// </summary>
        private bool IsDiagonalwWin()
        {
            if (saBoard[0, 0] == saBoard[1, 1] && saBoard[1, 1] == saBoard[2, 2] && !saBoard[2,2].Equals("0"))
            {
                eWinningMove = winningMove.Diag1;
                winningLine = "001122";
                return true;
            }
            else if (saBoard[0, 2] == saBoard[1, 1] && saBoard[1, 1] == saBoard[2, 0] && !saBoard[2,0].Equals("0"))
            {
                eWinningMove = winningMove.Diag2;
                winningLine = "021120";
                return true;
            }
            else
                return false;
        }




        /// <summary>
        /// Definition of Vertical Win
        /// </summary>
        private bool IsVerWin()
        {
            if (saBoard[0, 0] == saBoard[1, 0] && saBoard[1, 0] == saBoard[2, 0] && !saBoard[2,0].Equals("0"))
            {
                eWinningMove = winningMove.Col1;
                winningLine = "001020";
                return true;
            }
            else if (saBoard[0, 1] == saBoard[1, 1] && saBoard[1, 1] == saBoard[2, 1] && !saBoard[2,1].Equals("0"))
            {
                eWinningMove = winningMove.Col2;
                winningLine = "011121";
                return true;
            }

            else if (saBoard[0, 2] == saBoard[1, 2] && saBoard[1, 2] == saBoard[2, 2] && !saBoard[2,2].Equals("0"))
            {
                eWinningMove = winningMove.Col3;
                winningLine = "021222";
                return true;
            }
            else
                return false;

        }


        /// <summary>
        /// Definition of Horizontal Win
        /// </summary>
        private bool IsHorWin()
        {
            if (saBoard[0, 0] == saBoard[0, 1] && saBoard[0, 1] == saBoard[0, 2] && !saBoard[0,2].Equals("0"))
            {
                eWinningMove = winningMove.Row1;
                winningLine = "000102";
                return true;
            }
            else if (saBoard[1, 0] == saBoard[1, 1] && saBoard[1, 1] == saBoard[1, 2] && !saBoard[1,2].Equals("0"))
            {
                eWinningMove = winningMove.Row2;
                winningLine = "101112";
                return true;
            }

            else if (saBoard[2, 0] == saBoard[2, 1] && saBoard[2, 1] == saBoard[2, 2] && !saBoard[2,2].Equals("0"))
            {
                eWinningMove = winningMove.Row3;
                winningLine = "202122";
                return true;
            }
            else
                return false;

        }
    }
}
