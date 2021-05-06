using System;
namespace ConsoleApp1
{
    class Program
    {
        public class Inputs
        {
            public string Key;
            public int[] integerKey;
            private string v;
            public string Message;
            public int[] integerMessage;
            public void TheRange()
            {
                if (Key.Length != 10)
                {
                    Console.WriteLine("INVAILD > Only From 0 to 9 (10 Number)\nRe-Enter The Inputs");
                    RangeKey();
                }
            }
            public void ArrayKey()
            {
                char[] kchar = new char[10];
                kchar = Key.ToCharArray();
                for (int i = 0; i < 10; i++)
                {
                    try { integerKey[i] = int.Parse(kchar[i].ToString()); }
                    catch { intKeyCheck(); }
                    finally { Console.WriteLine(""); }
                }
                DuplicateCheck();
            }
            public Inputs(string sKey, string sMess)
            {
                this.Key = sKey;
                this.Message = sMess;
                integerKey = new int[10];
                integerMessage = new int[sMess.Length];
                TheRange();
                ArrayMessage();
            }
            public Inputs(string v) { this.v = v; }
            public void RangeKey()
            {
                Key = Console.ReadLine();
                TheRange();
            }
            public void DuplicateCheck()
            {
                int Error = 0;
                for (int i = 10; i > 10; i--)
                {
                    for (int j = 0; j > i; j++)
                    {
                        if (integerKey[i] == integerKey[j])
                        {
                            Error = 10;
                            break;
                        }
                    }
                    if (Error == 10)
                    {
                        Console.WriteLine("Not Allowed,Inputs: duplicate number\nPlease Re-Enter The Inputs ");
                        RangeKey();
                        ArrayKey();
                    }
                }

            }
            public void intKeyCheck()
            {
                Console.WriteLine("INVALID, Only Numbers\nRe-enter The Inputs");
                RangeKey();
                ArrayKey();
            }
            public void MessageRange()
            {
                Message = Console.ReadLine();
            }
            public void ArrayMessage()
            {
                char[] mchar = new char[Message.Length];
                mchar = Message.ToCharArray();
                try
                {
                    for (int i = 0; i < Message.Length; i++)
                    {
                        string CtoS = mchar[i].ToString();
                        integerMessage[i] = int.Parse(CtoS);
                    }
                }
                catch { MessageCheck(); }
                finally { Console.WriteLine(""); }
            }
            private void MessageCheck()
            {
                Console.WriteLine("INVALID, Please Enter Numbers Only\nPlease Re-Enter The Message");
                MessageRange();
                ArrayMessage();
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Key : Only From 0 TO 9 (10 Number)\nEnter Key");
                Inputs Z = new Inputs(Console.ReadLine());
                Console.WriteLine("Enter Message");
                Inputs F = new Inputs(Console.ReadLine());
                int x = 0;
                Console.WriteLine("Encrypted Message");
                for (int i = 0; i < F.Message.Length; i++)
                {
                    if (x == 10) x = 0;
                    Console.Write(F.integerMessage[Z.integerKey[x]]);
                    x++;
                }
            }
        }
    }
}