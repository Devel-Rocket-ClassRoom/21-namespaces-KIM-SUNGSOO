using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 인사 테스트 ===");
Console.WriteLine("[격식체]");
Formal.Message fmessage = new Formal.Message();
fmessage.SayHello("홍길동");
fmessage.SayBye("홍길동");

Console.WriteLine("[비격식체]");
Casual.Message cmessage = new Casual.Message();
cmessage.SayHello("철수");
cmessage.SayBye("철수");
namespace Formal
{
    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"{name}님, 안녕하십니까!");
        }

        public void SayBye(string name) 
        {
            Console.WriteLine($"{name}님, 안녕히 가십시오!");
        }

    }
}

namespace Casual
{
    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"안녕, {name}!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"잘 가, {name}!");
        }
    }
}