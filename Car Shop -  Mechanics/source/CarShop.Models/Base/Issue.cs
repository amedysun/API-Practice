﻿namespace CarShop.Models.Base
{
    using CarShop.Models.Base.Common;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Issue : DeletableEntity<long>
    {
        [Required]
        [StringLength(int.MaxValue, MinimumLength = ValidationConstants.Min_Issue_Description_Length)]
        public string Description { get; set; }

        [Required]
        [Range(1, long.MaxValue)]
        public long VehicleId { get; set; }

        [ForeignKey(nameof(VehicleId))]
        public Vehicle Vehicle { get; set; }

        [Required]
        [Range(1, long.MaxValue)]
        public long StatusId { get; set; }

        [ForeignKey(nameof(StatusId))]
        public IssueStatus Status { get; set; }

        [Required]
        [Range(1, long.MaxValue)]
        public long PriorityId { get; set; }

        [ForeignKey(nameof(PriorityId))]
        public IssuePriority Priority { get; set; }
    }
}