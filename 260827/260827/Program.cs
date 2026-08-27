using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 3조 팀원 소개 ===");
       // 아래로 노승훈, 노준철 소개 '호출' 추가하기
        IntroMakom64();
        IntroMakom64();
        Wkdwnsk2();
      
        Console.WriteLine("=== 소개 끝 ===");
    }
    // 팀원별 메서드 추가하는 자리
    public static void IntroMakom64()
    {
        Console.WriteLine("안녕하세요. 3조 조장 노승훈입니다.");

    }
    public static void Wkdwnsk2()
    {
        Console.WriteLine("노준철 / 게임을 좋아합니다.");
    }
}