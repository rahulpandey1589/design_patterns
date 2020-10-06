using design_patterns.Factory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Factory.Interfaces
{
    public interface IAnimal
    {
        Animal CreateAnimal(AnimalEnum animal);
    }
}
