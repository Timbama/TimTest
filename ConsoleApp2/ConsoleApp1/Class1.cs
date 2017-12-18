using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Actor
    {
        //Atributes
        int moveSpeed;
        int xCord;
        int yCord;
        public Actor()
        {
            this.moveSpeed = 30;

        }
        public Actor(int xCord, int yCord)
        {
            this.xCord = xCord;
            this.yCord = yCord;
            this.moveSpeed = 30; 
        }
        public Actor(int movSpeed, int xCord, int yCord)
        {
            this.xCord = xCord;
            this.yCord = yCord;
            this.moveSpeed = movSpeed;
        }
        public void setPostion(int xCord,int yCord)
        {
            this.xCord = xCord;
            this.yCord = yCord;
        }
        

    }
}
