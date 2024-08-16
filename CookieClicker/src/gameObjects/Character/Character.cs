using Godot;
using System;

namespace Character.BattleTest {

    public partial class Character : Resource
    {
        
        [Export] public int hp {get; set;}
        [Export] public int mp {get; set;}
        [Export] public Mesh mesh {get; set;}
        public Character() {
            hp = 10;
            mp = 10;
            mesh = new SphereMesh();
        }
    }
}
