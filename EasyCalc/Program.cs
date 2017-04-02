using System;

class EasyCalc
{
        public static void Main()   {
            Console.WriteLine("Inserisci il primo numero: ");
            int a = GestoreIO.Leggi32();
            Console.WriteLine("Inserisci il secondo numero: ");
            int b = GestoreIO.Leggi32();
            Console.WriteLine("Inserisci il segno dell'operazione: ");
            int c = GestoreIO.LeggiChar();
            int ans = 0;
            switch (c)  {
                case 'x':
                    ans = Calcolatrice.Molt(a, b);
                    break;
                case '+':
                    ans = Calcolatrice.Somma(a, b);
                    break;
                case '-':
                    ans = Calcolatrice.Diff(a, b);
                    break;
                case '/':
                    ans = (int)Calcolatrice.Div(a, b);
                    break;
        }
        Console.WriteLine("Il risultato e: {0}", ans);
        Console.ReadKey();
    }

    class Calcolatrice
    {
        public static int Somma(int i, int z) {
            return i + z; }

        public static int Diff(int i, int z) {
            return i - z; }

        public static int Molt(int i, int z) {
            return i * z; }

        public static float Div(int i, int z) { 
            return i / z; }
    }

    class GestoreIO
    {
        public static int Leggi32() {
            return Convert.ToInt32(Console.ReadLine()); }

        public static char LeggiChar() { 
            return Console.ReadLine()[0]; }
    }

}