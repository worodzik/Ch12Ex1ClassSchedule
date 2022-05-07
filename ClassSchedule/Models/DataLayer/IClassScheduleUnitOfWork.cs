using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassSchedule.Models
{
    interface IClassScheduleUnitOfWork
    {
        public Class Class { get; }

        public Teacher Teacher { get; }
        public Day Day { get; }





        
       
    }
}
