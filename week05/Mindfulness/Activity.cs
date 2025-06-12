using System;
using System.Collections.Generic;
using System.Threading;


    abstract class Activity
    {
        private int _duration;
        private string _name;
        private string _description;

        // Static dictionary to keep track of how many times each activity has run
        private static Dictionary<string, int> _activityLog = new();

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;

            // Initialize count if not already present
            if (!_activityLog.ContainsKey(name))
                _activityLog[name] = 0;
        }

        public void Start()
        {
            Console.Clear();
            DisplayStartingMessage();
            SetDuration();

            Console.WriteLine("Get ready...");
            ShowSpinner(5);

            RunActivity();

            IncrementActivityCount();

            DisplayEndingMessage();
        }

        private void DisplayStartingMessage()
        {
            Console.WriteLine($"--- {_name} ---");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
        }

        private void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            ShowSpinner(3);
            Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
            ShowSpinner(3);
        }

        private void SetDuration()
        {
            int seconds = 0;
            while (seconds <= 0)
            {
                Console.Write("Enter duration in seconds: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out seconds) && seconds > 0)
                {
                    _duration = seconds;
                }
                else
                {
                    Console.WriteLine("Please enter a positive integer.");
                }
            }
        }

        public int GetDuration()
        {
            return _duration;
        }

        public void ShowSpinner(int durationSeconds)
        {
            string[] spinner = { "|", "/", "-", "\\" };
            int spinnerIndex = 0;
            int totalMilliseconds = durationSeconds * 1000;
            int interval = 250;

            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < totalMilliseconds)
            {
                Console.Write(spinner[spinnerIndex]);
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;
                Thread.Sleep(interval);
                Console.Write("\b");
            }
        }

        public void ShowCountdown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        // Increment usage count for this activity
        private void IncrementActivityCount()
        {
            if (_activityLog.ContainsKey(_name))
            {
                _activityLog[_name]++;
            }
            else
            {
                _activityLog[_name] = 1;
            }
        }

        // Static method to get the activity log summary for display
        public static void DisplayActivityLog()
        {
            Console.WriteLine("Activity usage counts this session:");
            foreach (var entry in _activityLog)
            {
                Console.WriteLine($"- {entry.Key}: {entry.Value} time(s)");
            }
            Console.WriteLine();
        }

        protected abstract void RunActivity();
    }