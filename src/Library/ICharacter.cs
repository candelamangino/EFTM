using System.Collections;

namespace Library;

public interface ICharacter
{
    string Name { get; }
    int Health { get; set; }
    void Attack(ICharacter objective);
    void Heal();
    int ObtainAttackValue();
    int ObtainDefenseValue();
}