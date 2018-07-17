using SQLite.Net.Interop;

namespace SQLite.Net
{
    internal class Platform
    {
        internal class WinRT
        {
            internal class SQLitePlatformWinRT : ISQLitePlatform
            {
                public ISQLiteApi SQLiteApi => throw new System.NotImplementedException();

                public IStopwatchFactory StopwatchFactory => throw new System.NotImplementedException();

                public IReflectionService ReflectionService => throw new System.NotImplementedException();

                public IVolatileService VolatileService => throw new System.NotImplementedException();
            }
        }
    }
}