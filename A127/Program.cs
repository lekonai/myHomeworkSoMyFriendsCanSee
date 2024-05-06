using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace A127;

class Program
{
    static void Main(string[] args)
    {
        // string input = Console.ReadLine();
        // if (input.Length == 0)
        // {
        //     Console.WriteLine("i'm not even gonna throw-catch you, goodbye");
        //     Thread.Sleep(2000);
        //     Environment.Exit(0);
        // }
        // RUNITBACKNOWYALL(input);
        
        // string inp2 = Console.ReadLine();
        // CAPITAL(inp2);
        
        EorO(1,10);
        EorO(0,10);
    }

    static string RUNITBACKNOWYALL(string STRINGINP) // I HATE RECURSIVE PROGRAMMING GRAHWRUIYGBAIUYWFGBV
    {
        if (STRINGINP.Length >= 1)
        {
            Console.Write(STRINGINP[STRINGINP.Length - 1]);
            RUNITBACKNOWYALL(STRINGINP.Substring(0, STRINGINP.Length - 1));
        }
        return STRINGINP; // nvm this was easier than imagined
    }

    static void CAPITAL(string strINP)
    {
        char curCHAR = strINP[0];
        if ((int)curCHAR > 64 && (int)curCHAR < 91)
        {
            Console.WriteLine(curCHAR);
        }
        else
        {
            CAPITAL(strINP.Substring(1,strINP.Length - 1));
        }
    }
    
    static void EorO(int val, int len)
    {
        if (val > len)
        {
            Console.WriteLine("END");
        }
        else
        {
            Console.Write(val);
            Console.Write(" ");
            EorO(val + 2, len);
        }
    }
    
}