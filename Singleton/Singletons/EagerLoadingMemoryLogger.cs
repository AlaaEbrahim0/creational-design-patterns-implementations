﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Singletons;

public class EagerLoadingMemoryLogger
{
    private int _InfoCount = 0;
    private int _WarningCount = 0;
    private int _ErrorCount = 0;

    private static readonly EagerLoadingMemoryLogger _Logger = new EagerLoadingMemoryLogger();

    private EagerLoadingMemoryLogger()
    {

    }

    public static EagerLoadingMemoryLogger GetInstance()
    {
        return _Logger;
    }

    private List<LogMessage> _logs = new List<LogMessage>();
    public IReadOnlyCollection<LogMessage> Logs => _logs;

    private void Log(string message, LogType type)
    {
        _logs.Add(new LogMessage()
        {
            Message = message,
            LogType = type,
            CreatedAt = DateTime.Now,
        });
    }

    public void LogInfo(string message)
    {
        ++_InfoCount;
        Log(message, LogType.INFO);
    }
    public void LogWarning(string message)
    {
        ++_WarningCount;
        Log(message, LogType.WARNING);
    }
    public void LogError(string message)
    {
        ++_ErrorCount;
        Log(message, LogType.ERROR);
    }

    public void ShowLog()
    {
        foreach (LogMessage log in _logs)
        {
            Console.WriteLine(log);
            Console.WriteLine("-------------------------------");
        }
        Console.WriteLine(_InfoCount);
        Console.WriteLine(_WarningCount);
        Console.WriteLine(_ErrorCount);
    }

}
