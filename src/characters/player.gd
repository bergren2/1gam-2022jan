extends KinematicBody2D

export var speed = 400.0

# Declare member variables here. Examples:
# var a = 2
# var b = "text"


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	var direction = Vector2.ZERO
	if Input.is_action_pressed("move_right"):
		direction = Vector2.RIGHT
		$AnimationPlayer.play("Walk_Right")
	if Input.is_action_pressed("move_left"):
		direction = Vector2.LEFT
		$AnimationPlayer.play("Walk_Left")
	if Input.is_action_pressed("move_down"):
		direction = Vector2.DOWN
		$AnimationPlayer.play("Walk_Down")
	if Input.is_action_pressed("move_up"):
		direction = Vector2.UP
		$AnimationPlayer.play("Walk_Up")
		
	position += direction * speed * delta
