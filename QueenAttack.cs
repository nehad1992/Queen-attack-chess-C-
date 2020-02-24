using System;

class Queen {
  static int[] MovementOfQueen () {
    Console.WriteLine ("Enter your x coordinate for Queen");
    int xQueen = int.Parse (Console.ReadLine ());
    Console.WriteLine ("Enter your y coordinate for Queen");
    int yQueen = int.Parse (Console.ReadLine ());
    int[] queenCoordinates = { xQueen, yQueen };
    return queenCoordinates;
  }
  static int[] MovementOfOtherPiece () {
    Console.WriteLine ("Enter x coordinate for other chess piece");
    int xOtherPiece = int.Parse (Console.ReadLine ());
    Console.WriteLine ("Enter y coordinate for other chess piece");
    int yOtherPiece = int.Parse (Console.ReadLine ());
    int[] otherPieceCoordinates = { xOtherPiece, yOtherPiece };
    return otherPieceCoordinates;
  }
  static bool Slope (int[] queenCoords, int[] otherPieceCoords) {

    int m = (queenCoords[1] - otherPieceCoords[1]) / (queenCoords[0] - otherPieceCoords[0]);
    if (m == 1 || m == -1) {
      return true;
    } else if (queenCoords[0] == otherPieceCoords[0] || queenCoords[1] == otherPieceCoords[1]) {
      return true;
    } else {
      return false;
    }
  }

  static void Main () {
    int[] queenCoords = MovementOfQueen ();
    int[] otherPieceCoords = MovementOfOtherPiece ();

    if (Slope (queenCoords, otherPieceCoords)) {
      Console.WriteLine ("Other piece is dead");
    } else {
      Console.WriteLine ("Other piece saved");
    }

  }
}