using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace String
{
    class StringBuilderTest
    {
        // C# StringBuilder
        // 문자열을 다루는 중요한 클래스 중 하나는 System.Text.StringBuilder 클래스이다.
        // String 클래스는 Immutable 하기 때문에, 문자열 갱신이 많은 프로그램에는 적당하지 않다.
        // 하지만 StringBuilder 클래스는 Mutable 하기 때문에 이 클래스가 별도의 메모리를 생성, 소멸하지 않고
        // 일정한 버퍼를 가지고 문자열 갱신을 효율적으로 처리하기 때문이다.
        // 특히, 루프 안에서 계속 문자열을 추가 변경하는 코드는 String 대신 StringBuilder를 사용하는 것이 좋다.
        public void stringBuilderTest()
        {
            // StringBuilder 를 이용해 문자열을 계속 추가합니다.
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 26; i++)
            {   
                sb.Append(i.ToString());
                // 다음 라인으로 이동합니다, 엔터와 같은 효과
                sb.Append(System.Environment.NewLine);
            }
            string s = sb.ToString();
            Console.WriteLine(s);
        }
    }
}
