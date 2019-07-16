using System;
using System.Collections.Generic;
using System.Text;

namespace RoverEngine
{
    public class Rover
    {
        private int[] position = { 0, 0 };
        private int[] land;
        static readonly LinkedList<char> directions =
            new LinkedList<char>(new[] { 'N', 'W', 'S', 'E' });
        char chrhdg;
        public Rover(int x, int y, char hdg, int[] plt)
        { 
            position[0] = x;
            position[1] = y; ;
            land = plt;
            LinkedListNode<char> heading = directions.Find(hdg);
            chrhdg = hdg;
        }
        public void DisplayPosition()
        {
            Console.WriteLine(position[0].ToString() + ' ' + position[1].ToString() + ' ' + chrhdg);
        }
        public string ReturnPosition()
        {
            return (position[0].ToString() + ' ' + position[1].ToString() + ' ' + chrhdg);
        }
        public void MoveRover(string command)
        {
            int length = command.Length;
            LinkedListNode<char> heading = directions.Find(chrhdg);
            for (int i = 0; i < length; i++)
            {
                heading = directions.Find(chrhdg);
                switch (command[i])
                {
                    case 'L':
                        chrhdg = (heading.Next ?? heading.List.First).Value;
                        break;
                    case 'R':
                        chrhdg = (heading.Previous ?? heading.List.Last).Value;
                        break;
                    case 'M':
                        switch (chrhdg)
                        {
                            case 'N':
                                if (position[1] < land[1])
                                    position[1]++;
                                break;                                       
                            case 'W':                                        
                                if (position[0] > 0)                         
                                    position[0]--;                           
                                break;                                       
                            case 'S':                                        
                                if (position[1] > 0)                         
                                    position[1]--;                           
                                break;                                       
                            case 'E':                                        
                                if (position[0] < land[0])                   
                                    position[0]++;                           
                                break;
                        }
                        break;
                }
            }
        }
        
    }
}
