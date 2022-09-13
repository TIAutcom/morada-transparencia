using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.MORADA.SOL.OBJETO.TRANSFERENCIA
{
    public class DFileUploadProjeto
    {
        private string _fileName;
        private int _trsnpa;

        public int IdProjeto
        {
            get { return _trsnpa; }
            set { _trsnpa = value; }
        }

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public DFileUploadProjeto(string nome, int id)
        {
            _fileName = nome;
            _trsnpa = id;
        }
    }
}
