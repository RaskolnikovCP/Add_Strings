// adding two strings which store numbers without using library functions

        public string AddStrings(string num1, string num2)
        {

            long sum = 0;

            string result;

            long a = 0;

            long b = 0;

            int sign1 = 0, sign2 = 0;

            int offset1, offset2;

            if (num1[0].Equals('-'))
            {

                sign1 = -1;

            }

            if (num2[0].Equals('-'))
            {

                sign2 = -1;

            }

            if (sign1 == -1)
            {

                offset1 = 1;

            }
            else
            {

                offset1 = 0;

            }

            if (sign2 == -1)
            {

                offset2 = 1;

            }

            else
            {

                offset2 = 0;

            }


            for (int i = offset1; i < num1.Length; i++)
            {

                a *= 10;

                a += num1[i] - 48;

            }



            for (int j = offset2; j < num2.Length; j++)
            {

                b *= 10;

                b += num2[j] - 48;

            }


            if (sign1 == -1)
            {

                a *= -1;

            }

            if (sign2 == -1)
            {

                b *= -1;

            }

            Console.WriteLine("a: " + a + "\n");

            Console.WriteLine("b: " + b + "\n");

            sum = a + b;

            result = sum.ToString();

            return result;

        }
