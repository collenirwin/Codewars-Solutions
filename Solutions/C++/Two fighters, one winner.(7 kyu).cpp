std::string declareWinner(Fighter* fighter1, Fighter* fighter2,
  std::string firstAttacker)
{
  Fighter* f1;
  Fighter* f2;
  
  if (fighter1->getName() == firstAttacker)
  {
    f1 = fighter1;
    f2 = fighter2;
  }
  else
  {
    f1 = fighter2;
    f2 = fighter1;
  }
  
  while (true)
  {
    f1->setHealth(f1->getHealth() - f2->getDamagePerAttack());
    f2->setHealth(f2->getHealth() - f1->getDamagePerAttack());
    
    if (f2->getHealth() <= 0)
    {
      return f1->getName();
    }
    else if (f1->getHealth() <= 0)
    {
      return f2->getName();
    }
  }
}