// This is a personal academic project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БД_курс
{
    public class Sotrudniki
    {
        private int kod_sotrudnika;
        public int Kod_sotrudnika
        {
            get
            {
                return kod_sotrudnika;
            }
            set
            {
                kod_sotrudnika = value;
            }
        }
        private string FIO;
        public string Fio
        {
            get
            {
                return FIO;
            }
            set
            {
                FIO = value;
            }
        }
        //private int otdel;
        //public int Otdel
        //{
        //    get
        //    {
        //        return otdel;
        //    }
        //    set
        //    {
        //        otdel = value;
        //    }
        //}
        private int doljnost;
        public int Doljnost
        {
            get
            {
                return doljnost;
            }
            set
            {
                doljnost = value;
            }
        }
        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public Sotrudniki() { }
        public Sotrudniki(int k, string f, int d, string l, string p)
        {
            Kod_sotrudnika = k;
            Fio = f;
            Doljnost = d;
            Login = l;
            Password = p;
        }
        //public Sotrudniki(int k, string f, int o, int d, string l, string p)
        //{
        //    Kod_sotrudnika = k;
        //    Fio = f;
        //    //Otdel = o;
        //    Doljnost = d;
        //    Login = l;
        //    Password = p;
        //}

        public string[] GetInfo()
        {
            string[] t = { kod_sotrudnika.ToString(), FIO, /*otdel.ToString(),*/ doljnost.ToString(), login, password };
            return t;
        }
    }
}
