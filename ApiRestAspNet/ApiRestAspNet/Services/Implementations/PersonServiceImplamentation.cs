using ApiRestAspNet.Model;

namespace ApiRestAspNet.Services.Implementations
{
    public class PersonServiceImplamentation : IPersonService
    {
        private volatile int count;

        Person IPersonService.Create(Person person)
        {
            return person;
        }

        void IPersonService.Delete(long id)
        {
        
        }

        List<Person> IPersonService.FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }


        Person IPersonService.FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Vitor",
                LastName = "Calado",
                Address = "Vista Alegre",
                Gender = "Male"
            };                
        }

        Person IPersonService.Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Last Name",
                Address = "Some Address",
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
