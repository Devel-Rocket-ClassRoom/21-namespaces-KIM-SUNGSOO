using System;
using System.Security.Cryptography.X509Certificates;
using MyGame.Charaters;
using MyGame.Items;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 캐릭터 시스템 ===");

Player player = new Player();
player.Attack();

Enemy enemy = new Enemy();
enemy.TakeDamage();

Weapon weapon = new Weapon();
weapon.GetDamage(50);

Potion potion = new Potion();
potion.Use();
namespace MyGame.Charaters
{
    class Player
    {
        public string Name = "용사";

        public void Attack()
        {
            Console.WriteLine($"플레이어 {Name}(이)가 공격합니다!");
        }
    }

    class Enemy
    {
        public string Type = "고블린";

        public void TakeDamage()
        {
            Console.WriteLine($"적 {Type}(이)가 데미지를 받았습니다!");
        }
    }
}
namespace MyGame.Items
{
    class Weapon
    {
        public string Name = "불꽃검";

        public void GetDamage(int attack)
        {
            
            Console.WriteLine($"무기 {Name}의 공격력: {attack}");
        }
    }
    class Potion
    {
        public string Name = "체력 포션";

        public void Use()
        {
            Console.WriteLine($"포션 {Name}을(를) 사용했습니다.");
        }
    }
}
