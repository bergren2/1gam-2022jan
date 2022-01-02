using Godot;

namespace TineyTim.characters
{
    public class Player : KinematicBody2D
    {
        [Export]
        private float _speed = 400;

        public override void _Process(float delta)
        {
            var animation = GetNode<AnimationPlayer>("AnimationPlayer");
            var direction = Vector2.Zero;

            // TODO change to constants
            if (Input.IsActionPressed("move_right"))
            {
                direction = Vector2.Right;
                animation.Play("Walk_Right");
            }
            else if (Input.IsActionPressed("move_left"))
            {
                direction = Vector2.Left;
                animation.Play("Walk_Left");
            }
            else if (Input.IsActionPressed("move_down"))
            {
                direction = Vector2.Down;
                animation.Play("Walk_Down");
            }
            else if (Input.IsActionPressed("move_up"))
            {
                direction = Vector2.Up;
                animation.Play("Walk_Up");
            }

            Position += direction * _speed * delta;
        }
    }
}