namespace gh_Day9_1
{
    // 과제 1. 유효한 아이디 검증
    // 아래 코드의 구현 의도를 충족시키는 프로그램을 작성하자.

    // 온라인 게임의 아이디 유효성 검사에 대한 기능을 추가하려고 한다.
    // ID에 특수문자('!', '@', '#', '$', '%', '^', '&', '*') 가 포함된 경우 허용하지 않는다.
    // 이 때 string 자료형에 IsAllowedID() 확장 메서드를 추가하여 ID에 대한 검증을 진행하고자 한다.


    // 확장 메소드에 대한 이해력 부족으로 코드를 작성하지 못했습니다 ;.; 죄송합니다..............

    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("아이디를 입력하세요 : ");
            string id = Console.ReadLine();

            if (id.IsAllowedID())
            {
                Console.WriteLine("ID가 유효합니다.");
            }
            else
            {
                Console.WriteLine("ID에 허용되지 않는 특수문자가 있습니다.");
            }
        }
    }


    // ID에 특수문자를 포함할 경우 허용하지 않는 확장메서드를 추가
    public static class NoSpecialChr
    {
        public static string IsAllowedID(this string text)
        {
            char[] charsToTrim = { '!', '@', '#', '$', '%', '^', '&', '*' };
            string[] words = .Split();
            foreach (string word in words) ;
        }
    }
}
