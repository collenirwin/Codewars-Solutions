using System;
using System.Linq;

namespace Kata
{
  public class CombatSimulator
  {
    public enum HitResult
    {
      FightOn,
      PcDead,
      EnemyDead
    }
    
    int pcHitPoints;
    int enemyHitPoints;
    
    int pcDefense;
    int enemyDefense;

    public CombatSimulator(int pcHitPoints, int pcDefense, int enemyHitPoints, int enemyDefense)
    {
      this.pcHitPoints = pcHitPoints;
      this.enemyHitPoints = enemyHitPoints;
      this.pcDefense = pcDefense;
      this.enemyDefense = enemyDefense;
    }

    public HitResult PcAttack(int attackRoll, int[] modifiers, int damage)
    {
      int mods = modifiers != null ? modifiers.Sum() : 0;
    
      if (attackRoll + mods > enemyDefense)
      {
        enemyHitPoints -= damage;
      }
      
      if (enemyHitPoints <= 0)
      {
        return HitResult.EnemyDead;
      }
      
      return HitResult.FightOn;
    }

    public HitResult EnemyAttack(int attackRoll, int[] modifiers, int damage)
    {
      int mods = modifiers != null ? modifiers.Sum() : 0;
    
      if (attackRoll + mods > pcDefense)
      {
        pcHitPoints -= damage;
      }
      
      if (pcHitPoints <= 0)
      {
        return HitResult.PcDead;
      }
      
      return HitResult.FightOn;
    }
  }
}