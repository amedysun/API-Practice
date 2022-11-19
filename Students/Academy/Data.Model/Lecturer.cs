﻿using Data.Base.Contracts;

namespace Data.Models
{
    #nullable enable

    public class Lecturer : SoftDeletableEntity<Guid>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public byte YearsOfExperience { get; set; }

        public ICollection<Subject>? Subjects { get; set; }
    }
}
