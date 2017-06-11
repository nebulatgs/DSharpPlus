﻿namespace DSharpPlus
{
    public class DiscordConfig
    {
        public Branch DiscordBranch { get; set; } = Branch.Stable;
        public string Token { get; set; } = "";
        public TokenType TokenType { get; set; } = TokenType.Bot;
        public LogLevel LogLevel { get; set; } = LogLevel.Info;
        public bool UseInternalLogHandler { get; set; } = false;
        public int LargeThreshold { get; set; } = 250;
        public bool AutoReconnect { get; set; } = false;
        public int ShardId { get; set; } = 0;
        public int ShardCount { get; set; } = 1;
        public int GatewayVersion { get; set; } = 5;
        public bool EnableCompression { get; set; } = true;

        public DiscordConfig() { }
        public DiscordConfig(DiscordConfig other)
        {
            this.DiscordBranch = other.DiscordBranch;
            this.Token = other.Token;
            this.TokenType = other.TokenType;
            this.LogLevel = other.LogLevel;
            this.UseInternalLogHandler = other.UseInternalLogHandler;
            this.LargeThreshold = other.LargeThreshold;
            this.AutoReconnect = other.AutoReconnect;
            this.ShardId = other.ShardId;
            this.ShardCount = other.ShardCount;
            this.EnableCompression = other.EnableCompression;
        }
    }
}
