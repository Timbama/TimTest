using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Grid
    {
        int xDim;
        int yDim;
        bool[,] grid = new bool[1,1];
        public Grid()
        {
            this.xDim = 10;
            this.yDim = 10;
            this.grid = new bool[xDim,yDim];
            for (int i = 0; i < xDim; i++)
            {
                for (int j = 0; j < yDim; j++)
                {
                    grid[i,j] = false;
                }
            }
        }
        public Grid(int xDim, int yDim)
        {
            this.xDim = xDim;
            this.yDim = yDim;
            for (int i = 0; i < xDim; i++)
            {
                for (int j = 0; j < yDim; j++)
                {
                    grid[i,j] = false;
                }
            }
        }
        public int gridXDim()
        {
            return xDim;
        }
        public int gridYDim()
        {
            return yDim;
        }
        public int gridArea(Grid grid)
        {
            return grid.xDim * grid.yDim;
        }
        public void addActor(Actor actor, int xCord, int yCord)
        {
            if(actor. == )


            grid[xCord,yCord] = true;
            actor.setPostion(xCord,yCord);          
        }
        public bool getCellContent(int xCord, int yCord)
        {
            return grid[xCord, yCord];
        }


        public void printGrid()
        {
            for (int i = 0; i < xDim; i++)
            {
                for (int j = 0; j < yDim; j++)
                {
                    if (grid[i, j])
                    {
                        Console.Write("A ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine("");
            }

        }
    }
}
