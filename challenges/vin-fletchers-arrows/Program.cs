using System;

namespace cosmosdblab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick arrow type:");
            Console.WriteLine("1 - Elite arrow");
            Console.WriteLine("2 - Beginner arrow");
            Console.WriteLine("3 - Marksman arrow");
            Console.WriteLine("4 - Custom arrow");
            string input = Console.ReadLine();

            Arrow arrow = input switch
            {
                "1" => Arrow.CreateEliteArrow(),
                "2" => Arrow.CreateBeginnerArrow(),
                "3" => Arrow.CreateMarksmanArrow(),
                  _ => Arrow.CreateCustomArrow()
            };

            Console.WriteLine($"Cost of arrow: {arrow.GetCost()} gold");
        
        }
    }

    class Arrow
    {
        public ArrowHead ArrowHead { get; set; }
        public Fletching Fletching { get; set; }
        public float ShaftLength { get; set; }

        public Arrow(ArrowHead arrowHead, Fletching fletching, float shaftLength)
        {
            ArrowHead = arrowHead;
            Fletching = fletching;
            ShaftLength = shaftLength;
        }

        public ArrowHead GetArrowHead() => ArrowHead;
        public Fletching GetFletching() => Fletching;
        public float GetShaftLength() => ShaftLength;

        public void SetArrowHead(ArrowHead arrowHead) => ArrowHead = arrowHead;
        public void SetFletching(Fletching fletching) => Fletching = fletching;
        public void SetShaftLength(float shaftLength) => ShaftLength = shaftLength;

        public float GetCost()
        {
            float cost = 0;
            if ((int) GetArrowHead() == 0) cost += 10;
            else if ((int) GetArrowHead() == 1) cost += 3;
            else if ((int) GetArrowHead() == 2) cost += 5;
            if ((int) GetFletching() == 0) cost += 10;
            else if ((int) GetFletching() == 0) cost += 5;
            else if ((int) GetFletching() == 0) cost += 3;
            cost += (float) (GetShaftLength()*0.05);
            return cost;

        }
        private static ArrowHead ChooseArrowHead()
        {
            Console.WriteLine("Pick arrowhead:");
            Console.WriteLine("1 - Steel");
            Console.WriteLine("2 - Wood");
            Console.WriteLine("3 - Obsidian");
            string input = Console.ReadLine();
            return input switch
            {
                "1" => ArrowHead.Steel,
                "2" => ArrowHead.Wood,
                "3" => ArrowHead.Obsidian
            };
        }

        private static Fletching ChooseFletching()
        {
            Console.WriteLine("Pick fletching:");
            Console.WriteLine("1 - Plastic");
            Console.WriteLine("2 - Turkey feathers");
            Console.WriteLine("3 - Goose feathers");
            string input = Console.ReadLine();
            return input switch
            {
                "1" => Fletching.Plastic,
                "2" => Fletching.TurkeyFeather,
                "3" => Fletching.GooseFeather
            };
        }

        private static float ChooseShaftLength()
        {
            Console.WriteLine("Pick length of arrow shaft in cm (Between 60-100): ");
            return Convert.ToByte(Console.ReadLine());
        }

        public static Arrow CreateEliteArrow() => new Arrow(ArrowHead.Steel, Fletching.Plastic, 95);
        public static Arrow CreateBeginnerArrow() => new Arrow(ArrowHead.Wood, Fletching.GooseFeather, 75);
        public static Arrow CreateMarksmanArrow() => new Arrow(ArrowHead.Steel, Fletching.GooseFeather, 65);
        public static Arrow CreateCustomArrow() => new Arrow(ChooseArrowHead(), ChooseFletching(), ChooseShaftLength());

    }
    
    enum ArrowHead { Steel, Wood, Obsidian };
    enum Fletching { Plastic, TurkeyFeather, GooseFeather };
}
