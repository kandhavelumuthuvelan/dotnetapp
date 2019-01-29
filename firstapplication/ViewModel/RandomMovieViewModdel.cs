using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using firstapplication.Models;

namespace firstapplication.ViewModel
{
    public class RandomMovieViewModdel
    {
        public Movie movie { get; set; }
        public List<Customer> customer { get; set; } 
    }

}