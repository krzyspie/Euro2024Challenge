namespace Euro2024Challenge.Shared.Database
{
    internal sealed class DatabaseOptions
    {
        public string? ConnectionString { get; set; }

        public int MaxRetryCount { get; set; }

        public int CommandTimeout { get; set; }
    }
}
