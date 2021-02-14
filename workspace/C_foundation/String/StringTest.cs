using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    // String 클래스
    class StringTest
    {
        // C# 의 키워드 String 은 .NET의 System.String 클래스와 동일허다.
        // 따라서 System.String 클래스의 모든 메서드와 속성을 사용할 수 있습니다.
        public void stringTestFunc()
        {

            // 문자열
            string s1 = "C#";
            string s2 = "Programming";
            // 문자
            char c1 = 'A';
            char c2 = 'B';
            // substring 
            string s3 = s1 + " " + s2;
            Console.WriteLine("s3 : " + s3);

            string subst = s3.Substring(3, 2);
            Console.WriteLine("subst : " + subst);
        }

        public void stringArrayTest()
        {
            string s = "C# Studies";
            // 문자열을 배열 인덱스로 한문자 액세스
            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, s[i]);
            }
            string s1 = "hellow";
            // 문자열을 문자배열로 변환
            char[] charArray = s1.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine("charArray{0} + {1}" ,i, charArray[i]);
            }

            char[] charArray2 = { 'A', 'B', 'C', 'D', 'E' };
            // 문자 배열을 문자열로 변환 
            string charToString = new string(charArray2);
            Console.WriteLine(charToString);

        }
    }
}
