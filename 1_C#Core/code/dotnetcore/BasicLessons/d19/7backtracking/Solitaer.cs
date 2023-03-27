using System;
/**
 * Solves English peg solitare with 32 field and 31 pegs with the
 * help of a recursive backtring algorithm.
 * I have not checked every move of the solution: only the first few
 * and last few moves. I hope all other are valid moves as well.
 * 
 * @author pape
 *
 */
public class Solitaer {

	/**
	 * the game board with values 1 (a peg), 2 (empty field), 0 (unused field)
	 */
	private GameBoard board = new GameBoard();
	
	/**
	 * the solution given as a sequence of board situations
	 */
	private GameBoard [] solution = new GameBoard[32];

    /**
	 * all four possible directions for a move (jump of a peg over another peg)
	 */
    private int[] directions = null;// board.getDirections();
	
	/**
	 * creates a new solitare instance with empty solution
	 * and initial start position of all pegs
	 */
	public Solitaer() {
        directions = board.getDirections();
        for (int i = 0; i < solution.Length; i++) {
			solution[i] = new GameBoard();
		}
	}
   /**
    * Starts the backtracking algorithm and prints out the solution
    * as the sequence of all resulting intermediate board situation
	*/
	public static void main(String[] args) {
		Solitaer solitaer = new Solitaer();

		////long t1 = System.currentTimeMillis();
		//if (solitaer.findSolution(1)) {
		//	Console.WriteLine("Solution found in " + (System.currentTimeMillis() - t1) + " [ms]");

		//	solitaer.printSolution();
		//} else {
		//	Console.WriteLine("No solution found!?");
		//}
	}

	/**
	 * Backtracking algorithm to solve the solitare puzzle
	 * 
	 * @param move current number of move, first move must be 1
	 */
	public bool findSolution(int move) {
		for (int x = 0; move <= 31 && x < board.getWidth(); x++) {
			for (int y = 0; y < board.getHeight(); y++) {
				foreach (int direction in  directions) {
					if (board.jump(x, y, direction)) {
						board.copyBoard(board, solution[move]);
						if (! (move >= 31 && board.isOccupied(3, 3))) {
							if ( findSolution(move + 1)) {
								return true;
							} else {
								board.jumpBack(x, y, direction);
							}
						} else {
							return true;
						}
					}
				}
			}			
		}
		
		return false;
	}

	/**
	 * Gibt die Lösung als Folge von Spielbrettern am Bildschirm aus.
	 *
	 */
	private void printSolution() {
		for (int zug = 0; zug < solution.Length; zug++) {
			solution[zug].print();
		}
	}
}
