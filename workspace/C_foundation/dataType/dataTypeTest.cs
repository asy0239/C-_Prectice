using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataType
{
    class dataTypeTest
    {
        public void test()
        {
            // Bool
            bool b = true;

            // Numeric
            short sh = -32768;
            int i = 2147483647;
            long l = 1234L;      // L suffix
            float f = 123.45F;   // F suffix
            double d1 = 123.45;
            double d2 = 123.45D; // D suffix
            decimal d = 123.45M; // M suffix

            // Char/String
            char c = 'A';
            string s = "Hello";

            // DateTime  2011-10-30 12:35
            DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

            int maxValueCheck = int.MaxValue;
            int minValueCheck = int.MinValue;

            // 벨류 타입의 최댓값과 최솟값을 확인할 수 있다. 숫자형 데이터 타입에서 사용가능합니다. 
            Console.WriteLine(maxValueCheck);
            Console.WriteLine(minValueCheck);
            Console.WriteLine("float " + float.MaxValue);
            Console.WriteLine("float " + float.MinValue);
            Console.WriteLine("char " + char.MinValue);

            int? n = null; // int n = null; 은 에러가 납니다. 이유는 value type 은 null을 가질 수 없습니다.
                           // c# 2.0 이후 null 값을 가질 수 있게 했는데 그것을 nullable이라 합니다.
                           // 사용 방법은 자료형 뒤에 '?' 를 이용합니다. 이는 컴파일 시 .NET 의 Nullable<T> 타입으로 변환합니다.
            n = 1001;
            bool? bl = null;
            
            Nullable<int> nullInt = null; 
            nullInt = 10; 
            int k = nullInt.Value; // int? 를 int로 할당합니다.








        }


    }
}
