using System;
using System.Collections.Generic;
using System.Text;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Units
{
    public abstract class Unit : IUnit
    {
        private int attackPoints;
        private int defensePoints;
        private int energyPoints;
        private int healthPoints;
        private string name;
        private int range;
        private int x;
        private int y;
        private ICombatHandler combatHandler;


        protected Unit(string name, int attackPoints, int defensePoints, int healthPoints, int energyPoints, int range, int x, int y)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.EnergyPoints = energyPoints;
            this.Range = range;
            this.X = x;
            this.Y = y;
        }


        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            set
            {
                //validation
                this.attackPoints = value;
            }
        }

        public ICombatHandler CombatHandler
        {
            get
            {
                return this.combatHandler;
            }

            protected set
            {
                //validation
                this.combatHandler = value;
            }
        }

        public int DefensePoints
        {
            get
            {
                return this.defensePoints;
            }

            set
            {
                //validation
                this.defensePoints = value;
            }
        }

        public int EnergyPoints
        {
            get
            {
                return this.energyPoints;
            }

            set
            {
                //validation
                this.energyPoints = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                //validation
                this.healthPoints = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                //validation
                this.name = value;
            }
        }


        public int Range
        {
            get
            {
                return this.range;
            }

            private set
            {
                //validation
                this.range = value;
            }
        }

        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                //validation
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                //validation
                this.y = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(string.Format(">{0} - {1} at ({2},{3})", this.Name, this.GetType().Name, this.x, this.y));
            if (this.HealthPoints > 0)
            {
                output.AppendLine(string.Format("-Health points = {0}", this.HealthPoints));
                output.AppendLine(string.Format("-Attack points = {0}", this.AttackPoints));
                output.AppendLine(string.Format("-Defense points = {0}", this.DefensePoints));
                output.AppendLine(string.Format("-Energy points = {0}", this.EnergyPoints));
                output.Append(string.Format("-Range = {0}", this.Range));
            }
            else
            {
                output.Append("(Dead)");

            }
            return output.ToString();
        }
    }
}
