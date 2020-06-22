using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCrud.Models
{
    public class EmployeeContex : DbContext
    {
        public  EmployeeContex(DbContextOptions<EmployeeContex> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }

}



   
