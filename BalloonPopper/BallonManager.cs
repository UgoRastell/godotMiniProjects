using Godot;
using System;

public partial class BallonManager : Node3D
{
    public int score = 0;

    [Export]
    public Label ScoreText;

    public int IncreaseScore(int amount)
    {
        Label scoreLabel = GetNode<Label>("ScoreText");
        score += amount;
        scoreLabel.Text = "Score: " + score.ToString();
        return score;
    }
}

