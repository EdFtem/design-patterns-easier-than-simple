namespace FactoryMethod
{
    public class LoggerProviderFactory
    {
        public static ILogger GetLoggerProvider(LoggerType loggerType)
        {
            switch (loggerType)
            {
                case LoggerType.Log4Net:
                    return new Log4NetLogger();
                case LoggerType.MyLogger:
                    return new MyLogger();
                default:
                    return new Log4NetLogger();
            }
        }
    }
}
