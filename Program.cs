using System;

namespace bb
{
    class Drobi
    {
        int ch;
        int zn;

        public Drobi(int a)
        {
            ch = a;
            zn = 1;
        }
        public Drobi(int a, int b)
        {
            ch = a;
            zn = b;
        }
        public Drobi(int a, int b, int z)
        {
            zn = b;
            ch = z * b + a;
        }
        public double Desyat()
        {
            return (double)(ch) / zn;
        }
        public static Drobi operator +(Drobi x, Drobi y)
        {
            return new Drobi(x.ch * y.zn + y.ch * x.zn, x.zn * y.zn);
        }
        public static Drobi operator -(Drobi x, Drobi y)
        {
            return new Drobi(x.ch * y.zn - y.ch * x.zn, x.zn * y.zn);
        }
        public static Drobi operator *(Drobi x, Drobi y)
        {
            return new Drobi(x.ch * y.ch, x.zn * y.zn);
        }
        public static Drobi operator /(Drobi x, Drobi y)
        {
            return new Drobi(x.ch * y.zn, x.zn * y.ch);
        }

    }

    class Method
    {
        public static void MyMethodCh(Drobi a, int x)
        {
            Console.WriteLine("Числитель изменён");
        }
        public static void MyMethodZn(Drobi a, int x)
        {
            Console.WriteLine("Знаменатель изменён");
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Drobi dr1 = new Drobi(3);
            Drobi dr2 = new Drobi(-1, 2);
            Drobi dr3 = new Drobi(4, 5, 2);
            Console.WriteLine(dr1.Desyat());
            
        }
    }
}
