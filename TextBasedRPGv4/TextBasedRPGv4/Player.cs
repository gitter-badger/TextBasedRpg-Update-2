namespace TextBasedRPGv4
{
    class Player
    {
        int hp;
        int score;
        int heavy_Attack;
        int light_Attack;

        public Player()
        {
            hp = 20;
            score = 0;
            heavy_Attack = 4;
            Light_Attack = 2;
        }

        public int HP
        {
            get { return hp; }
            set { hp = value;}
        }

        public int Score
        {
            get { return score; }
            set { score  = value; }
        }
        public int Heavy_attack
        {
            get { return heavy_Attack; }
            set { heavy_Attack = value; }
        }
        public int Light_Attack
        {
            get { return light_Attack; }
            set { light_Attack = value; }
        }
    }
}