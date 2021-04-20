using System;

namespace ConsoleRPG
{
    class Enemy
    {
        private string enemyname;
        private string enemyrace;
        private int enemyhealth;
        // Allegiences are factions a particular entity can align themselves with
        private string enemyallegience;

    }

    class Goblin : Enemy
    {
        Enemy goblin = new Enemy();

    }
}