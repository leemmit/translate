using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace translate.Classes
{
    class Wordbook
    {
        private string name;
        private string filepath;
        public string Name {get => name; set => name = value;}
        public string Filepath {get => filepath; set => filepath = value;}

        public Wordbook(string Name, string Filepath)
        {
            Name = name;
            Filepath = filepath;
        }

        
    }
}
