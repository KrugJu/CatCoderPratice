using System;

public class Block
{
    public int id;
    public int x;
    public int y;
    public char orientation;

    public Block(string input)
	{
        char[] array = input.ToCharArray();
        if (array.Length == 5)
        {
            id = Int32.Parse(array[0]);
            orientation = array[1];
            x = Int32.Parse(array[2]);
            y = Int32.Parse(array[3]);
            length = Int32.Parse(array[4]);
        }
	}
}
