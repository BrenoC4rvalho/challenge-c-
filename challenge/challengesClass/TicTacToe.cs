using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.challengesClass
{
    public class TicTacToe
    {
        static char[,] board;
        static char currentPlayer;
        static int moves;

        public static void Main()
        {
            bool jogarNovamente;

            do
            {
                InicializarJogo();

                bool gameEnded = false;

                do
                {
                    Console.Clear();
                    DesenharTabuleiro();
                    Console.WriteLine($"\nJogador {currentPlayer}, escolha uma posição (1-9): ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int pos) && pos >= 1 && pos <= 9)
                    {
                        if (MarcarPosicao(pos))
                        {
                            moves++;
                            if (VerificarVitoria())
                            {
                                Console.Clear();
                                DesenharTabuleiro();
                                Console.WriteLine($"\n🎉 Jogador {currentPlayer} venceu!");
                                gameEnded = true;
                            }
                            else if (moves == 9)
                            {
                                Console.Clear();
                                DesenharTabuleiro();
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
                            Console.WriteLine("❌ Posição já ocupada. Pressione ENTER.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("⚠️ Entrada inválida. Pressione ENTER.");
                        Console.ReadLine();
                    }

                } while (!gameEnded);

                Console.WriteLine("\nDeseja jogar novamente? (s/n)");
                jogarNovamente = Console.ReadLine().Trim().ToLower() == "s";

            } while (jogarNovamente);

            Console.WriteLine("👋 Até a próxima!");
        }

        static void InicializarJogo()
        {
            board = new char[3, 3] {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
            currentPlayer = 'X';
            moves = 0;
        }

        static void DesenharTabuleiro()
        {
            Console.WriteLine(" Jogo da Velha\n");
            Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");
        }

        static bool MarcarPosicao(int pos)
        {
            int row = (pos - 1) / 3;
            int col = (pos - 1) % 3;

            if (board[row, col] != 'X' && board[row, col] != 'O')
            {
                board[row, col] = currentPlayer;
                return true;
            }
            return false;
        }

        static bool VerificarVitoria()
        {
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
