using System;
namespace Basics
{
    public class Employee
    {
        
            String name;
            long phone;

            public Employee(String name, long phone){
                this.name = name;
                this.phone = phone;
            }

             public  String printDetails() {
                return name + " " + phone;
            }
        
    }
}
