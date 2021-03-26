using System;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = 123;
            object d = (object)c; // 값을 박싱해서 힙에 저장
            int e = (int)d; // 값을 언박싱해서 스택에 저장
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            float f = 3.14159265358979323846264338f;
            double g = 3.14159265358979323846264338;
            decimal h = 3.14159265358979323846264338m;
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
        }
    }
}
