using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    class TicTacToe
    {
        static char[,] board = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

        static char currentPlayer = 'X';

        static void Main()
        {
            int moves = 0;
            bool gameEnded = false;

            do
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"\nJogador {currentPlayer}, escolha uma posição (1-9): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int position) && position >= 1 && position <= 9)
                {
                    if (PlaceMark(position))
                    {
                        moves++;
                        if (CheckWin())
                        {
                            Console.Clear();
                            DrawBoard();
                            Console.WriteLine($"\n🎉 Jogador {currentPlayer} venceu!");
                            gameEnded = true;
                        }
                        else if (moves == 9)
                        {
                            Console.Clear();
                            DrawBoard();
                            Console.WriteLine("\n🤝 Empate!");
                            gameEnded = true;
                        }
                        else
                        {
                            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                        }
                    }
                    else
                    {
                        Console.WriteLine("❌ Essa posição já está ocupada. Pressione ENTER para tentar novamente.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("⚠️ Entrada inválida. Pressione ENTER para tentar novamente.");
                    Console.ReadLine();
                }

            } while (!gameEnded);

            Console.WriteLine("\nFim de jogo. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

        static void DrawBoard()
        {
            Console.WriteLine(" Jogo da Velha\n");
            Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");
        }

        static bool PlaceMark(int position)
        {
            int row = (position - 1) / 3;
            int col = (position - 1) % 3;

            if (board[row, col] != 'X' && board[row, col] != 'O')
            {
                board[row, col] = currentPlayer;
                return true;
            }
            return false;
        }

        static bool CheckWin()
        {
            // Linhas e colunas
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == currentPlayer &&
                     board[i, 1] == currentPlayer &&
                     board[i, 2] == currentPlayer) ||

                    (board[0, i] == currentPlayer &&
                     board[1, i] == currentPlayer &&
                     board[2, i] == currentPlayer))
                    return true;
            }

            // Diagonais
            if ((board[0, 0] == currentPlayer &&
                 board[1, 1] == currentPlayer &&
                 board[2, 2] == currentPlayer) ||

                (board[0, 2] == currentPlayer &&
                 board[1, 1] == currentPlayer &&
                 board[2, 0] == currentPlayer))
                return true;

            return false;
        }
    }
}
