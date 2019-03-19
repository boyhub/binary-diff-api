﻿using BinaryDiff.Result.Domain.Enums;
using BinaryDiff.Shared.Domain.Models;
using System;
using System.Collections.Generic;

namespace BinaryDiff.Result.Domain.Models
{
    public class DiffResult : BaseEntity
    {
        public Guid DiffId { get; set; }

        public DateTime Timestamp { get; set; }

        public ResultType Result { get; set; }

        public virtual ICollection<InputDifference> Differences { get; set; }
    }
}
