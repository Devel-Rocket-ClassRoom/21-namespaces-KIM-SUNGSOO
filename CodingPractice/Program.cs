using System;

// README.md를 읽고 아래에 코드를 작성하세요.


Foo.Car foocar = new Foo.Car();
foocar.Go();
Bar.Car barcar = new Bar.Car();
barcar.Go();

namespace Foo
{
    class Car
    {
        public void Go()
        {
            Console.WriteLine("Foo 네임스페이스의 Car 클래스");
        }
    }
}

namespace Bar
{
    class Car
    {
        public void Go()
        {
            Console.WriteLine("Bar 네임스페이스의 Car 클래스");
        }
    }
}
