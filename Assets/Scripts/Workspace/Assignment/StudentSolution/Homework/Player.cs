using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Player : Entity
    {
        public int score;
        Item[] items;

        public void CollectItem(Item item) { }
        protected void LevelUp() { }
    }
}
