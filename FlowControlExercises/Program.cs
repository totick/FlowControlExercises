using System;

namespace FlowControlExercises
{

    //Flow Control Exercises Lesson 042

    struct ImageSize
    {
        public float height;
        public float width;

        public ImageSize(float height, float width)
        {
            this.height = height;
            this.width = width;
        }
    };

    class MainClass
    {

        public static bool BetweenValues(int val1, int val2, int betweenVal){
            return betweenVal >= val1 && betweenVal <= val2;
        }

        public static int MaxValue(int val1, int val2){
            return val1 > val2 ? val1 : val2;
        }

        public static bool IsLandscape(ImageSize imageSize)
        {
            return imageSize.width > imageSize.height;
        }

        public static int CalculateDemeritPoints(int speedLimit, float speed)
        {
            float aboveSpeedLimit = speed - speedLimit;
            int demeritPoints = (int)(aboveSpeedLimit / 5);
            return demeritPoints;
        }

        public static void DoExercise_1()
        {
            //Exercise 1 (Is value between 1 and 10)

            const int val1 = 1, val2 = 10;

            Console.Write("Write a value between {0} and {1}: ", val1, val2);
            int inputVal = int.Parse(Console.ReadLine());

            Console.WriteLine("Value is {0}", inputVal);

            bool isBetween = BetweenValues(val1, val2, inputVal);

            if (isBetween)
            {
                Console.WriteLine("Valid value");
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }

        public static void DoExercise_2()
        {
            //Exercise 2 (Which value is MaxValue)

            Console.Write("Write two values (val1 val2): ");
            string[] values = Console.ReadLine().Split(' ');

            int val1 = int.Parse(values[0]);
            int val2 = int.Parse(values[1]);

            Console.WriteLine("Max value is: {0}", MaxValue(val1, val2));
        }

        public static void DoExercise_3()
        {
            //Exercise 3 (Is Image landscape or portrait)

            Console.Write("Write image size (height width): ");
            string[] values = Console.ReadLine().Split();
            ImageSize imageSize = new ImageSize(float.Parse(values[0]), float.Parse(values[1]));

            if(IsLandscape(imageSize))
            {
                Console.WriteLine("Image is a landscape image.");
            }
            else
            {
                Console.WriteLine("Image is a portrait image.");
            }
        }

        public static void DoExercise_4()
        {
            //Exercise 4 (Speed camera)

            Console.Write("Write speed limit: ");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.Write("Write speed of the car: ");
            float carSpeed = float.Parse(Console.ReadLine());

            if(carSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
                return;
            }

            int demeritPoints = CalculateDemeritPoints(speedLimit, carSpeed);
            Console.WriteLine("Total demerit points: {0}", demeritPoints);

            if(demeritPoints > 12)
            {
                Console.WriteLine("License suspended.");
            }

        }

        public static void Main(string[] args)
        {
            bool again = true;

            while(again)
            {
                Console.WriteLine("1. Value between 1 and 10\n2. Max value\n3. Image is Landscape or Portrait\n4. Speed camera");

                Console.WriteLine("Which exercise: ");
                int exerciseNr = int.Parse(Console.ReadLine());

                switch(exerciseNr)
                {
                    case 1: 
                        DoExercise_1();
                        break;
                    case 2:
                        DoExercise_2();
                        break;
                    case 3:
                        DoExercise_3();
                        break;
                    case 4:
                        DoExercise_4();
                        break;
                    default:
                        Console.WriteLine("Exercise {0} not available.", exerciseNr);
                        break;
                }

                Console.WriteLine("Continue? (y/n): ");
                string answer = Console.ReadLine().ToLower();

                if(answer != "y"){
                    again = false;
                }
            }

        }
    }
}
