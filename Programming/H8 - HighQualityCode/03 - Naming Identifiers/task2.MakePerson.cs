class Creature
{
  enum Sex { Handsome, Beautiful };
  class Person
  {
    public Sex sex { get; set; }
    public string name { get; set; }
    public int age { get; set; }
  }
  public void MakePerson(int personalIdentityNumber)
  {
    Person instanceOfPerson = new Person();
    instanceOfPerson.age = personalIdentityNumber;
    if ((personalIdentityNumber % 2) == 0)
    {
      instanceOfPerson.name = "Ice";
      instanceOfPerson.sex = Sex.Handsome;
    }
    else
    {
      instanceOfPerson.name = "Lidia";
      instanceOfPerson.sex = Sex.Beautiful;
    }
  }
}
