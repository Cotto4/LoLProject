using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LoLProject.Models
{
    public class Champion
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public double AttackRange { get; set; }
        public double APBase { get; set; }
        public double APPerLevel { get; set; }
        public double ADBase { get; set; }
        public double ADPerLevel { get; set; }
        public double HPBase { get; set; }
        public double HPPerLevel { get; set; }
        public double ArmorBase { get; set; }
        public double APRegenPerLevel { get; set; }
        public double HPRegen { get; set; }
        public double CritPerLevel { get; set; }
        public double SpellBlockPerLevel { get; set; }
        public double APRegenBase { get; set; }
        public double AttackSpeedPerLevel { get; set; }
        public double SpellBlockBase { get; set; }
        public double MoveSpeedBase { get; set; }
        public double AttackSpeedOffset { get; set; }
        public double CritBase { get; set; }
        public double HPRegenPerLevel { get; set; }
        public double ArmorPerLevel { get; set; }
    }

    public class ChampionDBContext : DbContext
    {
        public DbSet<Champion> Champions { get; set; }
    }
}