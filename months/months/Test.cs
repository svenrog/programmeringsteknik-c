using System;

namespace months
{
    class Test
    {
        public static int Input()
        {
            int input;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input > 0 && input < 13)
                { return input; }
                else
                {
                    //Console.WriteLine("Felaktigt värde, var god försök igen.");
                    //input = Input();
                }
            }
            catch
            {
                throw new InvalidCastException();
                //Console.WriteLine("Felaktigt värde, var god försök igen.");
                //input = Input();
            }
            throw new ArgumentException();
        }
    }
}
