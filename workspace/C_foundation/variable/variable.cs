using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    class variable
    {
        // 메서드안에서 해당 메서드의 로컬변수로 선언되거나,
        // 혹은 클래스 안에서 클래스내의 멤버들이 사용하는 전역 변수(Field)로 선언될 수 있다.
        // 로컬 변수 : 해당 메소드에서 사용되며 메소드 호출이 끝나면 소멸된다. 기본값이 자동으로 할당안되므로 값을 무조건 할당해야함
        // 전역 변수 : 클래스의 객체가 살아있는 동안 계속 존속하며 다른 메소드에서 참조할 수 있다. 기본값이 설정된다.
        // static 변수와 non-static 변수로 나뉜다.
        // static 변수 : 프로그램 실행과 동시에 메모리 영역에 독립적으로 존재하게 된다. 
        // 즉, 그 변수가 선언되지 않은 클래스에서도 해당 변수에 접근 가능
        // 다른 클래스에서 변경된 값이 또 다른 클래스에서도 변경된다
        // non-static 변수 : 객체 생성에 따라 메모리 영역에 할당되며 객체마다 다른 값을 가질 수 있다.

        // 필드 변수
        int globalVar; // 기본값이 0으로 선언
        // 상수
        const int Max = 1024;  // 상수는 초기 정한 값을 중간에 변경할 수 없다. 

        // readonly : 상수와 비슷한 개념, 말 그대로 읽기 전용이다.
        // 필드 선언부나 클래스 생성자에서 그 값을 지정할 수 있으며 런타임 시 값이 정해진다.
        readonly int roMax;
        public variable()
        {
            roMax = 10; // 생성자에서 선언 가능
        }
        public void Method1()
        {
            // 로컬 변수
            int localVar;
            localVar = 100; // 로컬 변수는 자동으로 할당이 안되기 떄문에 값을 할당해주어야 함
            // 혹은 int localVar = 100; 로 가능
            

            Console.WriteLine("globalVar " + globalVar); 
            Console.WriteLine("localVar "+ localVar);

        }

    }
}
