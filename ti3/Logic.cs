namespace ti3
{
    public static class Logic
    {
        public static string main_function(string new_string);
        {
            int a,ind,i;
            long a1;
            string b,key,second_string,nums;
            char b1;

            second_string = "";
            nums = "";
            for(int j = 1; j <= new_string.Length; i++)
            {
                if (new_string[j] != ' ')
                {
                    b = "";
                    a = new_string[j];
                    nums += IntToStr(a);
                    while (a > 1)
                    {
                        b += IntToStr(a % 2);
                        a = a / 2;
                    }
                    b += IntToStr(a);

                    while(b.Length != 8)
                    {
                        b = '0' + b;
                    }

                    a1 = 0;
                    ind = 7;
                    for (int i = 1; i <= 8; i++)
                    {
                        key = (j % 2 == 0) ? key2 : key1;
                        a1 += Power(2,ind)*((StrToInt(b[i] + '') + StrToInt(key[i] + ''))mod 2);
                        ind = ind - 1;
                    }
                    b1 = chr(StrToInt(FloatToStr(a1)));
                }
                else
                {
                    b1 = ' ';
                }
                second_string = second_string + b1;
            }
            return second_string;
        }
    }
}