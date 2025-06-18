using System;
using System.Collections.Generic;


    abstract class Goal
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Points { get; private set; }
        protected bool completed = false;
        public bool Completed => completed;

        public Goal(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
        }

        public abstract int RecordEvent();
        public abstract string DisplayStatus();
    }

