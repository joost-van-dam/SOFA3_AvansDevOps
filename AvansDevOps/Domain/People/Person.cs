﻿namespace AvansDevOps.Domain.People
{
    internal abstract class Person
    {
        private string firstName { get; }
        private string lastName { get; }
        private string email { get; }

        protected Person(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public string GetEmail()
        {
            return this.email;
        }

    }
}
