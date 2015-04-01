﻿namespace SchoolClasses
{
    using System;

    public abstract class Person : ICommentable
    {
        private string name;

        protected Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public string Comment { get; set; }
    }
}