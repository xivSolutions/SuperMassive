using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AdventureWorks;


namespace AdventureWorksExamples
{
    public class Repo
    {
        AdventureWorks.AdventureWorksEntities Db = new AdventureWorks.AdventureWorksEntities();

        public IEnumerable<Person> getPeople()
        {
            var people = Db.People;
            var query = from p in people where p.LastName.StartsWith("s") select p;
            return people.ToList();
        }
    }
}
