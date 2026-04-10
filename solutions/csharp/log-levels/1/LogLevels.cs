static class LogLine
{
    public static string Message(string logLine)
    {

        //        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
        return logLine.Substring( logLine.IndexOf(":") + 1 ).Trim();    
    }

    public static string LogLevel(string logLine){ 

//        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
        return logLine.Substring(1, logLine.IndexOf("]") - 1).ToLower();
}

    public static string Reformat(string logLine)
    {
//        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
        return $"{ Message(logLine) } ({ LogLevel(logLine) })";
    }
}
