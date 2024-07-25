namespace gh_Day8
{
    internal class Program
    {

        /*   과제 1. 갑옷과 내구도
            아래 코드의 빈칸을 작성하여 구현 의도를 충족시키는 프로그램을 작성하자.
            플레이어가 피격을 받을 때마다 착용 중인 갑옷의 내구도를 1씩 감소시킨다.
            갑옷의 내구도가 0이 될 때, 플레이어가 갑옷을 해제(UnEquip) 하도록 한다.   */


        // 교수님 풀이예제를 기반으로 하여 주석으로 개인적인 해석을 달아줌

        public class Player
        {
            private Armor curArmor;

            public void Equip(Armor armor)
            {
                Console.WriteLine($"플레이어가 {armor.name} 을/를 착용합니다.");
                curArmor = armor;
                curArmor.OnBreaked += UnEquip; // 빈칸 : 방어구가 부서졌을 때, 이벤트:Break가 발생하게 함.
            }

            public void UnEquip()
            {
                Console.WriteLine($"플레이어가 {curArmor.name} 을/를 해제합니다.");
                curArmor.OnBreaked -= UnEquip; // 빈칸 : 이미 Equip에서 방어구가 부서질 때 UnEquip가 이벤트로 발생하게 작성하였으므로,
                                               //        더 이벤트가 발생하지 않도록 OnBreaked를 -= 하여 null로 만들었다.
                curArmor = null;
            }

            public void Hit()  // 빈칸
            {
                Console.WriteLine("피격되었습니다! 방어구의 내구도가 감소합니다.");
                curArmor.DecreaseDurability(); // 갑옷의 내구도를 감소시킨다.
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

            private void Break()  // 빈칸
            {
                Console.WriteLine("방어구가 부서집니다!");

                if (OnBreaked != null)
                {
                    OnBreaked();
                }
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
    }
}
