using System.Collections.Generic;


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Duck Hunter Incremental iniciado!");

        Game game = new Game();

        Console.WriteLine("Proyecto compilado correctamente.");
    }
}
public class Game
{
    public int currentRound;
    public int requiredPoints;
    public bool endlessMode;

    public Player player;
    public List<Duck> ducks;

    public void StartGame()
    {

    }

    public void SpawnDuck()
    {

    }

    public void CheckRoundEnd()
    {

    }

    public void NextRound()
    {

    }
}


public class Player
{
    public int score;
    public int lives;

    public Shotgun weapon;

    public void Shoot()
    {

    }

    public void AddScore(int points)
    {

    }

    public void LoseLife()
    {

    }
}

public class Shotgun
{
    public int damage;
    public int ammo;
    public int maxAmmo;

    public float fireRate;

    public void Shoot()
    {

    }

    public void Reload()
    {

    }

    public void UpgradeDamage()
    {

    }

    public void UpgradeAmmo()
    {

    }
}

public class Duck
{
    public int health;
    public float speed;

    public int pointValue;

    public void Move()
    {

    }

    public void TakeDamage(int damage)
    {

    }

    public void Die()
    {

    }
}

