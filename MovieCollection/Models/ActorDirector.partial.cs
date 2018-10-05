﻿using MovieCollection.Domain;
using System;

namespace MovieCollection.Models
{
    public partial class ActorDirector
    {
        public class ActorDirectorValidationException : Exception
        {
            public ActorDirectorValidationException(string message) : base(message)
            {
            }
        }

        public bool IsNew { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public void Validate(ActorDirectorGetter actorDirectorGetter)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ActorDirectorValidationException("Name cannot be blank.");
            if (!IsActor && !IsDirector)
                throw new ActorDirectorValidationException("You must select either \"Is Actor\" or \"Is Director\" (or both)");
            if (actorDirectorGetter.IsExistingByName(Name, Id))
                throw new ActorDirectorValidationException(
                    $"An actor or director named {Name} already exists.");
        }
    }
}
