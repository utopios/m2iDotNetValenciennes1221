using System;

namespace LeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting implicite [slide33]
            short @short = 200;
            int @int = @short;
            Console.WriteLine(@int); //200
            #endregion

            #region Casting Explicite [slide34]
            int @int2 = 200000;
            short @short2 = (short)int2; // il faut préfixer la variable contenant la valeur du type du receptacle
            Console.WriteLine(@short2);
            #endregion

            Console.ReadLine();
        }
    }
}
