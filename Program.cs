﻿namespace CAHashSetsandSortedSets {
    internal class Program
    {
        private static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
     new Customer { Name = "Issam A", Telephone = "+1 123 123 4565" },
            new Customer { Name = "Reem S", Telephone = "+1 123 123 4566" },
                 new Customer { Name = "Issam B", Telephone = "+1 123 123 4567" },
                 new Customer { Name = "Abeer A", Telephone = "+1 123 123 4568" },
                 new Customer { Name = "Salem D", Telephone = "+1 123 123 4569" }
            };
             //   var cust1 = new Customer { Name = "Issam A", Telephone = "+1 123 123 4567" };
            //var cust2 = new Customer { Name = "Issam A", Telephone = "+1 123 123 4567" };
            //Console.WriteLine(cust1.Name.GetHashCode());
            // Console.WriteLine(cust1 == cust2);
          //  Console.WriteLine(cust1.Equals(cust2));
            //Console.WriteLine(object.ReferenceEquals(cust2, cust1));
            
          Console.WriteLine("Hashsets");
            Console.WriteLine("-------");
            var custhashSet1 = new HashSet<Customer>(customers);
            var customers2 = new List<Customer>
            {
     new Customer { Name = "Essam A", Telephone = "+1 123 123 4533" },
            new Customer { Name = "Rim S", Telephone = "+1 123 123 4554" }
            };
            var custhashSets2 = new HashSet<Customer>(customers2);
            custhashSet1.UnionWith(custhashSets2);
            //   custhashSet1.Add(new Customer { Name = "Issam Bb", Telephone = "+1 123 123 4563" });
            foreach (var item in custhashSet1)

               Console.WriteLine(item);
            Console.WriteLine("SortedSet");
            Console.WriteLine("-------");
            var customerSortedSet = new SortedSet<Customer>(customers);
            customerSortedSet.Add(new Customer { Name = "Baker S", Telephone = "+1 123 123 3354" });
            foreach (var item in customerSortedSet)
                Console.WriteLine(item);
            //Console.ReadKey();
        }
       
    } 
    class Customer :    IComparable<Customer>
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 397 + Telephone.GetHashCode();
            return hash;
        }
        public override bool Equals(object? obj)
        {
            var customer = obj as Customer;
            if (customer is null)
                return false;

            return this.Telephone.Equals(customer.Telephone);
        }
        public override string ToString()
        {
            return $"{Name} ({Telephone})";
        }

        public int CompareTo(Customer? other)
        {
            if(object.ReferenceEquals(this, other))
                return 0 ;
            if ((other is null))
                return -1 ;
            
            return this.Name.CompareTo(other.Name);
        }
    }
}