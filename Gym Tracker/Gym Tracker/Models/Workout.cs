﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gym_Tracker.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Musclegroup { get; set; }
        public string Description { get; set; }
        public Workout()
        {

        }
    }
}
