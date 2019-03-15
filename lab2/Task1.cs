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
        string[] setOfElements;
        int size;
        public Combinations(string Elements)
        {
            this.SetOfElements =Elements.Split(',');
            this.Size = (int)Math.Pow(2, SetOfElements.Length);
            this.allCombinations = new string[Size, SetOfElements.Length];
            CreateCombinations();
        }

        void CreateCombinations()
        {
            string mask;
            for(int i=0;i<Size;i++)
            {
                mask = Convert.ToString(i, 2).PadLeft(SetOfElements.Length, '0');
                if (mask.Length > SetOfElements.Length)
                {
                    throw new Exception("Проблемы с вычислением маски");
                }

                for (int j=0;j< mask.Length; j++)
                {
                    if(mask[j]=='1')
                    {
                       allCombinations[i, j] = SetOfElements[j];
                    }
                    else
                    {
                        allCombinations[i, j] = "";
                    }
                }
            }
        }

        public void Print()
        {
            bool comma;
            Console.WriteLine(" - Генератор множества всех подмножеств -");
            Console.Write("Исходное множество: <");
            
            for (int j = 0; j < SetOfElements.Length; j++)
            {
                Console.Write(SetOfElements[j]);
                
                if (j < SetOfElements.Length - 1)
                    Console.Write(',');
            }
            Console.WriteLine(">, всего: "+Size+" элементов:");
            
            for (int i=0;i<Size;i++)
            {
                Console.Write(i + ": <");
                comma = false;

                for (int j=0;j< setOfElements.Length;j++)
                {                   
                    if (allCombinations[i, j] != "")
                    {
                        if (comma)
                            Console.Write(',');

                        Console.Write(allCombinations[i, j]);

                        if (!comma)
                            comma = true;
                    }
                }
                Console.WriteLine('>');
            }
        }

        public string[] SetOfElements { get => setOfElements; private set => setOfElements = value; }
        public string[,] AllCombinations { get => AllCombinations; private set => AllCombinations = value; }
        public int Size { get => size; private set => size= value; }
    }
}