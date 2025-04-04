using System;



    public class Player
    {
        private int xp;
        private float health;

        public string Name {get;}
        private float maxHealth;

        public float MaxHealth{
            get{
                return maxHealth = 100+(Level-1)*20;
            }
        }
        public int Level
        {
            get{
                return 1+XP/1000;
            }
        }
        public float Health
        {
            get{
                return health;
            }
            set{

                if(value<0)
                    health = 0;
                else if (value > MaxHealth)
                        health = MaxHealth;
                else
                    health = value;
            }
        }
        public int XP
        {
            get{
                return xp;
            }
            set{
                xp += value;
            }
        }
        public Player(string name)
        {
            Name = name;
            health = MaxHealth;
            xp = 0;
        }


        public void TakeDamage(float damage)
        {
            Health = health-damage;
            XP = Convert.ToInt32(damage/20);
        }

    }

