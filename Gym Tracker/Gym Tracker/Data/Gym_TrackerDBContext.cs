using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gym_Tracker.Models;

namespace Gym_Tracker.Data
{
    public class Gym_TrackerDBContext : DbContext
    {
        public Gym_TrackerDBContext (DbContextOptions<Gym_TrackerDBContext> options)
            : base(options)
        {
        }

        public DbSet<Gym_Tracker.Models.Workout> Workout { get; set; }
    }
}
