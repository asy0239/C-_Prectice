using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_열거형_
{
    class flag_enum
    {
        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2, 
            Bottom = 4,
            Left = 8
        }

        public void flagTest()
        {
            // OR 연산자로 다중 플래스 할당
            Border b = Border.Top | Border.Bottom;
            Console.WriteLine(b.HasFlag(Border.None));
            // & 연산자로 플래그 체크
            if ((b & Border.Top) != 0)
            {
                // HasFlag() 이용 플래그 체크
                if (b.HasFlag(Border.Bottom))
                {
                    // "Top, Bottom" 출력
                    Console.WriteLine(b.GetHashCode());

                }
            }

        }
    }
}
