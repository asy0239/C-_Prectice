using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_열거형_
{
    class enumTest
    {
        // enum 은 열겨형 상수(constant)를 표현하기 위한 것으로 이를 이용하여 상수 숫자들을 보다 의미있는 단어들로 표현
        // enum 의 갹 요소는 별도의 지정없이는 첫번째 요소가 0, 두번째 요소가 1, 세번째 요소가 2 등과 같이 1씩 증가된 값들을 할당받는다.
        // 사용자가 임의로 의미있는 번호를 지정해 줄 수도 있다.
        // enum 문은 클래스 안이나 네임스페이스 내에서만 선언할 수 있다.
        enum city
        {
            Seoul, // 0
            Daejun, // 1
            Busan = 5,
            Jeju = 10
        }
        public void enumTestFunc()
        {
            // 선언과 동시에 enum 타입에 값을 대입하는 방법
            city myCity = city.Seoul;

            int cityValue = (int)myCity;

            if(myCity == city.Seoul)
            {
                Console.WriteLine("Welcome to Seoul");
            }
            Console.WriteLine("seoul : " + myCity);
            Console.WriteLine("enum_seoul : " + cityValue);
        }
    }
}
