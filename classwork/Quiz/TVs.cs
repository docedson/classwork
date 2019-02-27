using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class TVs
    {
        int Size { get; set; }
        int Ports { get; set; } 
        decimal Price { get; set; }
        bool IsMountable { get; set; }

        public abstract void TVType(int Size, int Ports, decimal Price, bool IsMountable);
        
        public TVs(int Size, int Ports, decimal Price, bool IsMountable)
        {
            
        }







    }
          
}