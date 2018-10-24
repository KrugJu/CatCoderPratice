using System;

public class Block
{
    public int id;
    //x and y coordinates of the bottom left half of the block
    public int x;
    public int y;
    public char orientation;
    public int length;

    public Block(int id,char orientation,int x, int y,int length)
	{
        this.id = id;
        this.orientation = orientation;
        this.x = x;
        this.y = y;
        this.length = length;
	}
}
