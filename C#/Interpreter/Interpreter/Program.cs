using System;

namespace Interpreter
{
    class MainClass
    {
        //public static void Main(string[] args)
        //{
        //    string Description1 = "Futbol maçlarını çok sevsem de, genelde izlemiyorum";
        //    string Description2 = "Bebeğimin sağlığı için anne sütüne çok önem veriyorum.";
        //    string Description3 = "Spor'a giderken arabayı vurdum.";

        //    bool expResult = false;
        //    string word = "futbol";
        //    string word2 = "araba";

        //    string word3 = "anne";
        //    string word4 = "bebe";
        //    string word5 = "sürt";
        //    string word6 = "çiz";


        //    Console.Write(Description1 + " (Erkek):");
        //    //futbol || araba
        //    expResult = Description1.ToLower().Contains(word.ToLower()) || Description1.ToLower().Contains(word2.ToLower());
        //    Console.WriteLine(expResult);

        //    //anne || bebe , sürt && araba , çiz && araba
        //    Console.Write(Description2 + "(Bayan):");
        //    expResult = ((Description2.ToLower().Contains(word3.ToLower()) || Description2.ToLower().Contains(word4.ToLower()))
        //        || (Description2.ToLower().Contains(word5.ToLower()) && Description2.ToLower().Contains(word2.ToLower()))
        //        || (Description2.ToLower().Contains(word6.ToLower()) && Description2.ToLower().Contains(word2.ToLower())));
        //    Console.WriteLine(expResult);

        //    //anne || bebe , sürt && araba , çiz && araba
        //    Console.Write(Description3 + "(Bayan):");
        //    expResult = ((Description3.ToLower().Contains(word3.ToLower()) || Description3.ToLower().Contains(word4.ToLower()))
        //       || (Description3.ToLower().Contains(word5.ToLower()) && Description3.ToLower().Contains(word2.ToLower()))
        //       || (Description3.ToLower().Contains(word6.ToLower()) && Description3.ToLower().Contains(word2.ToLower())));
        //    Console.WriteLine(expResult);

        //    Console.ReadLine();
        //}

        public static void Main(string[] args)
        {
            string Description1 = "Futbol maçlarını çok sevsem de, genelde izlemiyorum";
            string Description2 = "Bebeğimin sağlığı için anne sütüne çok önem veriyorum.";
            string Description3 = "Spor'a giderken arabayı vurdum.";

            Console.Write(Description1 + " (Erkek):");
            Console.WriteLine(InterpretPattern.getMaleExpression().Interpret(Description1));

            bool expResult = false;
            Console.Write(Description2 + "(Bayan):");
            foreach (Expression exp in InterpretPattern.getFemailExpressions())
            {
                if (exp.Interpret(Description2)) { expResult = true; break; }
            }
            Console.WriteLine(expResult);

            bool expResult2 = false;
            Console.Write(Description3 + "(Bayan):");
            foreach (Expression exp in InterpretPattern.getFemailExpressions())
            {
                if (exp.Interpret(Description3)) { expResult2 = true; break; }
            }
            Console.WriteLine(expResult2);
            Console.ReadLine();
        }
    }
}
