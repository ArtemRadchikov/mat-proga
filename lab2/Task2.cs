using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Combinations
    {       
        string[,] allCombinations;

        public Combinations(int m,Subsets s)
        {   
            CreateCombinations(m,s);
        }

        public Combinations(int m,String str)
        {
            CreateCombinations(m,new Subsets(str));
        }

        void CreateCombinations(int m,Subsets s)
        {
            int n = s.SetOfElements.Length;
            if(n>m)
                throw 
        }
    }
}
