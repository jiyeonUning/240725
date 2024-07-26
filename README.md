# 과제 1. 갑옷과 내구도

아래 코드의 빈칸을 작성하여 구현 의도를 충족시키는 프로그램을 작성하자.


조건 1. 플레이어가 피격을 받을 때마다 착용 중인 갑옷의 내구도를 1씩 감소시킨다.

조건 2. 갑옷의 내구도가 0이 될 때, 플레이어가 갑옷을 해제(UnEquip) 하도록 한다.


 public class Player
        {
            private Armor curArmor;

            public void Equip(Armor armor)
            {
                Console.WriteLine($"플레이어가 {armor.name} 을/를 착용합니다.");
                curArmor = armor;
                // 빈칸
            }

            public void UnEquip()
            {
                Console.WriteLine($"플레이어가 {curArmor.name} 을/를 해제합니다.");
                // 빈칸 

                curArmor = null;
            }

            public void Hit()  
            {
                // 빈칸
            }
        }

        public class Armor
        {
            public string name;
            private int durability;

            public event Action OnBreaked;

            public Armor(string name, int durability)
            {
                this.name = name;
                this.durability = durability;
            }

            public void DecreaseDurability()
            {
                durability--;
                if (durability <= 0)
                {
                    Break();
                }
            }

            private void Break() 
            {
                // 빈칸
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Armor ammor = new Armor("갑옷", 3);

            player.Equip(ammor);

            player.Hit();
            player.Hit();
            player.Hit();
        }
