using System;
using System.Collections.Generic;


namespace Confectionery
{
    abstract class Confectionery
    {
        public abstract Cake MakeCake();
        public abstract List<Muffin> MakeMuffins(int number);
        public abstract List<Cookie> MakeCookie(int number);
    }

    abstract class Muffin
    {
        public string Name { get; protected set; }
    }
    abstract class Cake
    {
        public string Name { get; protected set; }
    }
    abstract class Cookie
    {
        public string Name { get; protected set; }
    }

    class KontiConfectionery : Confectionery
    {
        public override Cake MakeCake()
        {
            return new PragueCake("an amazing Konti Prague Cake");
        }
        public override List<Muffin> 
        MakeMuffins(int number)
        {
            List<Muffin> muffins = new List<Muffin>();
            for (int i = 0; i < number; i++)
            {
                muffins.Add(new FrenchMuffin(String.Format("a beautiful French Muffin {0}", i + 1)));
            }
            return muffins;
        }
        public override List<Cookie>
        MakeCookie(int number)
        {
            List<Cookie> cookies = new List<Cookie>();
            for (int i = 0; i < number; i++)
            {
                cookies.Add(new ChocolateCookie(String.Format("a lovely Chocolate Cookie {0}", i + 1)));
            }
            return cookies;
        }
    }
    class PragueCake : Cake
    {
        public PragueCake(string name)
        {
            Name = name;
        }
    }
    class ChocolateCookie : Cookie
    {
        public ChocolateCookie(string name)
        {
            Name = name;
        }
    }
    class FrenchMuffin : Muffin
    {
        public FrenchMuffin(string name)
        {
            Name = name;
        }
    }
    class AVKConfectionery : Confectionery
    {
        public override Cake MakeCake()
        {
            return new PragueCake("an amazing AVK Prague Cake");
        }
        public override List<Muffin>
        MakeMuffins(int number)
        {
            List<Muffin> muffins = new List<Muffin>();
            for (int i = 0; i < number; i++)
            {
                muffins.Add(new FrenchMuffin(String.Format("a beautiful French Muffin {0}", i + 1)));
            }
            return muffins;
        }
        public override List<Cookie>
        MakeCookie(int number)
        {
            List<Cookie> cookies = new List<Cookie>();
            for (int i = 0; i < number; i++)
            {
                cookies.Add(new ChocolateCookie(String.Format("a lovely Chocolate Cookie {0}", i + 1)));
            }
            return cookies;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var confectionery1 = new KontiConfectionery();

            Console.WriteLine(confectionery1.MakeCake().Name);
            confectionery1.MakeMuffins(7).ForEach((m) => Console.WriteLine(m.Name));
            confectionery1.MakeCookie(5).ForEach((p) => Console.WriteLine(p.Name));

            Console.WriteLine();

            var confectionery2 = new AVKConfectionery();
            Console.WriteLine(confectionery2.MakeCake().Name);
            confectionery2.MakeMuffins(3).ForEach((m) => Console.WriteLine(m.Name));
            confectionery2.MakeCookie(3).ForEach((p) => Console.WriteLine(p.Name));

        }
    }
}
