using System;

namespace Task11
{
    class Program
    {
        static void Main()
        {
            ProgramConverter[] array = new ProgramConverter[2];
            array[0] = new ProgramConverter();
            array[1] = new ProgramHelper();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is ICodeChecker)
                {
                    var tmp = array[i] as ProgramHelper;
                    Console.WriteLine(tmp.CheckCodeSyntax("", ""));
                }
                else
                {
                    Console.WriteLine(array[i].ConvertToCSharp("aa"));
                    Console.WriteLine(array[i].ConvertToVB("bb"));
                }
            }

            Console.ReadKey();
        }
    }
}
