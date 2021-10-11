using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    interface Cars
    {
        String Name { set; get; }
        int Id { set; get; }
        String Color { set; get; }
        double Price { set; get; }
        void Add_data();
        String[] Show_result();


    }
}
