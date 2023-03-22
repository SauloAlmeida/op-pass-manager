﻿using PassManagerAPI.Entities;

namespace PassManagerAPI.DTO.Input
{
    public class PasswordInput
    {
        public string Address { get; set; }
        public IList<PasswordAccessInput> Access { get; set; } = new List<PasswordAccessInput>();

        public void Validate()
        {
            if (string.IsNullOrEmpty(Address))
                throw new Exception($"The property {nameof(Address)} can't be null or empty.");

            if (Access.Any() is false)
                throw new Exception($"It's necessary to inform at least one access.");
        }

        public Password ToEntity() => new(Address, Access.Select(s => new PasswordAccess(s.Login, s.Password)));
    }
}
