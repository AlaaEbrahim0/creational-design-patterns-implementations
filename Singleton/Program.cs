using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using Singleton.Singletons;

namespace Singleton;

public class Program
{
    static ThreadUnsafeMemoryLogger logger;

    static void Main(string[] args)
    {
        logger = ThreadUnsafeMemoryLogger.GetInstance();
        AssingVoucher("abc", "v1");
        UseVoucher();
        logger.ShowLog();

    }

    static void AssingVoucher(string email, string voucher)
    {
        logger = ThreadUnsafeMemoryLogger.GetInstance();
        logger.LogInfo($"Voucher '{voucher}' assigned");
        logger.LogError($"unable to send email:  '{email}'");

    }

    static void UseVoucher()
    {
        logger = ThreadUnsafeMemoryLogger.GetInstance();
        logger.LogWarning("text");
        logger.LogInfo("text2");
    }

}

public class Singleton
{
    private Singleton()
    {
        
    }

    public int Num { get; set; } = 4;

    private static Singleton instance = new Singleton();

    public static Singleton Create()
    {

        return instance;

    }
}

