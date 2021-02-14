using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @operator
{
    class operatorTest
{
        public void Optor()
        {
            int a = 0;
            int b = 1;
            int c = 2;
            // 기본적인 연산은 다른 언어들과 비슷
            // c# 엔 아직 익숙하지 않은 쉬프트연산자( >>, << ), 조건연산자 (??) 가 있다. 
            // >> 은 2 의 이진수 10 을 01 로 옮기는 것
            // << 은 10 를 100 으로 옮기는 것, 즉 비트의 자리수를 옮기는 것
            c = c >> 1;
            Console.WriteLine(c);
        }
}
}
