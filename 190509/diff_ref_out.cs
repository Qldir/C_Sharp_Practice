static void Main(string[] agrs)
{
    int a = 0; //ref 변수는 반드시 초기화해야됨
    int b;
    MyMethod(ref a, out b);
    Console.WriteLine(String.Format("a값:{0}, b값:{1}", a, b));
}

static void MyMethod(ref int a, out int b)
{
    a = 11;
    b = 22;
}



// out : 출력 매개 변수
// 1. 변수 초기화 필요치 않음 : 출력용 이기 때문에 함수로 전달되기 전 변수값 할당은 무의미 하다
// 2. 함수내 반드시 변수에 값 할당 : 출력용 이기 때문에 함수내에서 변수 값이 할당 되어야 함.
// ref : 참조에 의한 전달
// 1. 변수 초기화 필요 : 일반 매개변수와 같은 의미
// 2. 함수내 값 설정하지 않아도 됨
// 출처 : https://winflahed.tistory.com/9
