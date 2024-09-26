using System.Collections;

namespace Library;

public interface ICharacter
{
    int Health { get; set; }
    void Attack(ICharacter objective);
    void Heal();
    int ObtainAttackValue();
    int ObtainDefenseValue();
}