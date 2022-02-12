using System.Collections;
using System.Collections.Generic;

public class Queen 
{
    int queenNumber = 0;
    string queenName = "";
    List<string> possibleMoves = new List<string>();
    public string queenXYChessCoords = "";

    
    public Queen(int queenNumberToSet, string queenNameToSet, List<string> possibleMovesToSet, string queenXYChessCoordsSet)
    {
        queenNumber = queenNumberToSet;
        queenName = queenNameToSet;
        possibleMoves = possibleMovesToSet;
        queenXYChessCoords = queenXYChessCoordsSet;
    }
    public int getQueenNumber()
    {
        return queenNumber;
    }
    public void setQueenNumber(int queenNumberToSet)
    {
        queenNumber = queenNumberToSet;
    }

    public string getQueenName()
    {
        return queenName;
    }
    public void setQueenName(string queenNameToSet)
    {
        queenName = queenNameToSet;
    }

    public List<string> getPossibleMoves()
    {
        return possibleMoves;
    }
    public void setPossibleMoves(List<string> possibleMovesToSet)
    {
        possibleMoves = possibleMovesToSet;
    }

    public string getQueenXYChessCoords()
    {
        return queenXYChessCoords;
    }
    public void setQueenXYChessCoords(string queenXYChessCoordsSet)
    {
        queenXYChessCoords = queenXYChessCoordsSet;
    }
}