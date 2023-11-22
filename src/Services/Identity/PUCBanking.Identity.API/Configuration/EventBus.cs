﻿namespace PUCBanking.Identity.API.Configuration {
    public class EventBus {
        public string ConnectionString { get; set; } = null!;
        public string SubscriptionClientName { get; set; } = null!;
        public string BrokenName { get; set; } = null!;
        public int RetryCount { get; set; }
    }
}
