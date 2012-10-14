InstanceListPattern
===================

Easily make your object maintain an internal list of instances, relies on the programmer to Dispose();

Here is an example:

    namespace InstanceListPatternSample
    {
        class Person : InstanceList<Person>
        {
            public Person(string name)
            {
                this.Name = name;
            }

            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            } 
        }
        class Program
        {
            static void Main(string[] args)
            {
                Person p1 = new Person("p1");
                Person p2 = new Person("p2");

                PrintAllPersons(); 
                
                Person p3 = new Person("p3");

                PrintAllPersons();

                p3.Dispose();

                PrintAllPersons();

                Console.Read();
            }

            private static void PrintAllPersons()
            {
                Console.WriteLine("All instances:");
                foreach (var p in Person.Instances) {
                    Console.WriteLine(p);
                }
            }
        }
    }

Print output:

    All instances:
    p1
    p2
    All instances:
    p1
    p2
    p3
    All instances:
    p1
    p2
