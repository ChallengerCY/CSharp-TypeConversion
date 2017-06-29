using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypeConversion
{
    class DisplayTypeAndImplicitTypeConversionDemo
    {
        static void Main(string[] args)
        {
            //强类型语言就是会在编译的时候进行类型检测
            //隐式转换 由小类型转换为大类型
            int i = 10;
            long l = i;
            //类的隐式转换
            C1 c1 = new C2();
            //显式转换（会报错，数据丢失）
            double d = 10.05;
            int ifrom = (int)d;
            Console.WriteLine(ifrom);
            //类的显示转换
            C1 c11 = new C1();
            //通过try catch捕获异常
            try
            {
                C2 c2 = (C2)c11;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //通过is关键字判断是否是子类
            Console.WriteLine(c1 is C1);
            Console.WriteLine(c1 is C2);
            Console.WriteLine(c11 is C1);
            Console.WriteLine(c11 is C2);
            //如果想要安全的类型转换，需要使用as，as用作引用类型和非空类型,如果无法强类型转换，则会赋给一个空值
            C2 c22= c11 as C2;
            Console.WriteLine(c22 == null);
            Console.ReadLine();
        }
     
        class C1 { 
    
        }
        class C2 : C1 { 
        
        }
    }
}
