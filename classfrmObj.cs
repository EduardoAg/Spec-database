using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Database
{
    class clsNuevoMat
    {
        //public clsNuevoMat(string _catalogo, int _codigosap, string _marca, int _intmarca, string _familia, int _intfamilia, 
        //string _descripcion, string _specul, string _specenercom, string _specvarias, string _speccatalogo, string _spectexto)
        //{
        //    this.catalogo = _catalogo;
        //    this.codigosap = _codigosap;
        //    this.marca = _marca;
        //    this.intmarca = _intmarca;
        //    this.familia = _familia;
        //    this.intfamilia = _intfamilia;
        //    this.descripcion = _descripcion;
        //    this.specul = _specul;
        //    this.specenercom = _specenercom;
        //    this.specvarias = _specvarias;
        //    this.speccatalogo = _speccatalogo;
        //    this.spectexto = _spectexto;
        //}
        private string _catalogo;
        private int _codigosap;
        private string _marca;
        private int _intmarca;
        private string _familia;
        private int _intfamilia;
        private string _descripcion;
        private string _specul;
        private string _specenercom;
        private string _specvarias;
        private string _speccatalogo;
        private string _spectexto;
        public string catalogo
        {
            get { return _catalogo; }
            set { _catalogo = value; }
        }
        public int codigosap
        {
            get { return _codigosap; }
            set { _codigosap = value; }
        }
        public string marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public int intmarca
        {
            get { return _intmarca; }
            set { _intmarca = value; }
        }
        public string familia
        {
            get { return _familia; }
            set { _familia = value; }
        }
        public int intfamilia
        {
            get { return _intfamilia; }
            set { _intfamilia = value; }
        }
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public string specul
        {
            get { return _specul; }
            set { _specul = value; }
        }
        public string sepcenercom
        {
            get { return _specenercom; }
            set { _specenercom = value; }
        }
        public string specvarias
        {
            get { return _specvarias; }
            set { _specvarias = value; }
        }
        public string speccatalogo
        {
            get { return _speccatalogo; }
            set { _speccatalogo = value; }
        }
        public string spectexto
        {
            get { return _spectexto; }
            set { _spectexto = value; }
        }


    }
}
