﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //컨텍스트 키워드
            var abc = "Hello World"; //OK

            //한줄 ㅜ석
            /*
             * 
             * 
             * 여러줄 주석
             *             */
            /***XML주석 ***/

            //출력
            Console.WriteLine("Hellow World");
            Console.Write("뉴라인X");

            //1# 12-3 기본 자료형
            //정수형
            Console.WriteLine(52+4-1);
            //사칙 연산자 = 산술 연산자 = Arithmetic Operator
            //+ - * / %

            //실수형(Real Number)
            Console.WriteLine(52.0);

            //문자(Character)
            //외따옴표로 감싸야하고 한글자만 들어가야함
            Console.WriteLine('A');
            Console.WriteLine('가');

            //문자열(String)
            Console.WriteLine("Hello World");
            //이스케이프 문자
            Console.WriteLine("미\n\\림\t마\"고");
            //문자열 연결 연산자(Concatenation Operator)
            Console.WriteLine("Hello" + " " + "World");
            //문자열 인덱스 접근 [ ]
            Console.WriteLine("Hello World"[4]); //'o'
            //Console.WriteLine("Hello World"[100]); //예외 발생

            //주의
            Console.WriteLine('가' + '힣');
            //문자열 연결 연산자 X 덧셈 연산자로 인식

            //논리(boolean)
            Console.WriteLine(true);
            Console.WriteLine(false);
            //비교 연산자(Comparison Operator)
            // == != > < >= <=
            //논리 연산자(Logical Operator)
            // && || !
            Console.WriteLine(!true); //false
            Console.WriteLine(true && false); //false
            Console.WriteLine(true || false); //true

            //#1 12-4 변수
            // 변수(Variable)
            string name = "문자열 자료형";

            //#1 12-5 복합대입연산자
            // += -= * = /= %=
            string output = "Hello";
            output += "World";
            Console.WriteLine(output);

            //#1 12-6 증감연산자
            int number = 10;
            Console.WriteLine(number++); //10
            Console.WriteLine(++number); //12
            Console.WriteLine(number--); //12
            Console.WriteLine(--number); //10

            //#1 12-8 var 키워드
            //컴파일 시점에서 바뀜 지역변수에서만 사용 가능
            var varnumber = 20;
            //var abc; // x. 반드시 초기화 해줘야 함

            //#1 12-9 입력
            string input = Console.ReadLine();
            Console.WriteLine(input);

            //#1 12-10 자료형변환(*)
            //굉장히 중요

            //#2 13-1 if 조건문
            bool condition = true;
            if (condition)
            {
                //true
            }
            else if(condition)
            {
                 //true2
            }
            else
            {
                
                //other
            }

            //#2 13-2 switch 조건문
            int v = 0;
            switch (v)
            {
                //case뒤에는 꼭 상수여야함 변수는 X
                case 0:
                    //0
                    break;
                case 1:
                    //1
                    break;
                default:
                    //other
                    break;
            }

        }
    }
}
