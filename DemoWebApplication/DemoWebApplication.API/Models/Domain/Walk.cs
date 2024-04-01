﻿namespace DemoWebApplication.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double LengthInKm{ get; set; }

        public String? WalkImageUrl { get; set; }

        public Guid DifficultyId { get; set; }

        public Guid RegionId { get; set; }

        //Navigation Properties

        public Difficuilty Difficulty { get; set;}

        public Region Region { get; set; }
    }
}
