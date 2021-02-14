using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ArrayTest
    {
        // 배열은 동일안 DataType 요소들로 구성된 데이터 집합입니다.
        // 인덱스로 배열요소를 선택할 수 있습니다.
        // 배열 요소는 Square Bracket([]) 안에 인덱스를 넣어 표시합니다. ex) A[0], b[52]
        // c# 배열은 최고 32차 배열까지 가질 수 있습니다.
        // 다차원 배열은
        // 각 차원별 요소 크기가 고정된 Rectangular 배열, [,] 로 c언어 스타일로 ',' 로 분리하여 다차원을 표시합니다.
        // 각 차원별 크기가 서로 다른 가변배열로 나뉠 수 있습니다. [][] 와 같이 java 스타일로 각 차원마다 괄호를 별도로 사용합니다.




        public void arrayTest()
        {
            // 1차원 배열
            string[] players = new string[10];
            string[] regions = { "서울", "경기", "부산" };

            // 2차원 배열
            string[,] depts = { { "김과장", "총무부" }, { "안대리", "영업부" } };

            // 3차원 배열
            string[,,] Cudes;

            int[][] jaggedArr = new int[3][]{
            new int[] {31,33,2},
            new int[] {2,1,2,3,5},
            new int[] {1,2,3,5,7,8}
            
            };      
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                Console.Write("jaggedArr[ "+ i + " ] : ");
                int size = jaggedArr[i].Length;
                for (int j = 0; j < size; j++ )
                {
                    Console.Write(jaggedArr[i][j] + " ");
                }
                Console.WriteLine();

            }
        }



    }
}
