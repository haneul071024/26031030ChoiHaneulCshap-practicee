namespace _0930
{
    internal class Program
        {
            static void main(String[] args)
            {
              
                Parking[] carParking;

                Player player;

                Mob[] mobs;
                mobs = new Mob[1000];
                for(int i =0; i < mobs.Length; ++i)
                    {
                    mobs[i]=new Mob();
                    mobs[i].Name="몹이름 : " + i.ToString();
                    }
                for(int i =0; i < mobs.Length; ++i)
                {
                Console.WriteLine(mobs[i].Name);
                }

                System.Collections.Generic.List<Mob> mobs;

                List<Mob> mobs = new();
                for(int i=0; i<10; ++i)
                {
                    mobs.Add(new Mob());
                    mobs[i].Name = "몹이름: "+i.ToString();
                }
                foreach(var ob in mobs)
                {
                    Console.WriteLine(Mob.Name);
                }
                

                carParking = new Parking[100];
                player = new Player();
                mobs = new Mob[1000];

                Random random = new Random();
                     for (int i = 0; i < 100; i++)
                    {
                        //var rand
                        var randValue = random.Next();
                        Console.WriteLine(randValue);
                    }
                 }
       

    }
    
}
