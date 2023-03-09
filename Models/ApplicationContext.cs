﻿using Microsoft.EntityFrameworkCore;

namespace EmployeesMvc.Models
{
    public class ApplicationContext : DbContext
    {
        // Denna konstruktor krävs för att konfigurationen ska fungera
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :
            base(options)
        {
        }
        // Exponerar våra databas-modeller via properties av typen DbSet<T> 
        public DbSet<Employee> Employees { get; set; }
    }
}
