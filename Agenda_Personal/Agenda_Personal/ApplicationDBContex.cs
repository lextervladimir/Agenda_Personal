using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda_Personal
{
    public class ApplicationDBContex: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configura la cadena de conexion a tu base de datos
            optionsBuilder.UseSqlServer("Server=PERSONLAPW11\\SQL2025;Database=AgendaPersonalDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }

        public DbSet<Contact> Contacts { get; set; }

    }
}
