using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTestinimas
{
    interface IHerojus
    {
        string Vardas { get; }
        float HP { get; }
        float Atack { get; }
        float Defence { get; }

        void Attack_target();
        bool IsTargetDead(ITarget target);
    }
    interface ITarget
    {
        string Pavadinimas { get; set; }
        float Hp { get; set; }
        float Attack { get; set; }
        float Defence { get; set; }


    }
	
	class Herojus : IHerojus{

public string Vardas{ get;}
public float HP {get;}		
        public float Attack { get; }
        public float Defence { get; }

        public void Attack_Target()
        {
            Console.WriteLine("Atakuoti");
        }

        public bool IsTargetDead(ITarget target)
        {
            if (target.Hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
	}

    class Priesas : ITarget
    {
        public string Pavadinimas { get; set; }
        public float Hp { get; set; }
        public float Attack { get; set; }
        public float Defence { get; set; }
    }
}
