﻿using System.Collections.Generic;

namespace HangFire.Storage
{
    public class QueueWithTopEnqueuedJobsDto
    {
        public string QueueName { get; set; }
        public long Length { get; set; }
        public HashSet<string> Servers { get; set; } 
        public IList<KeyValuePair<string, EnqueuedJobDto>> FirstJobs { get; set; }
    }
}