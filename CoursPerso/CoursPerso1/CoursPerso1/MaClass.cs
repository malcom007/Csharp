using System;
namespace CoursPerso1
{
    public class MaClass
    {
       
            private String _Nom, _Prenom;
            private int _Age;

            public MaClass(String nom, String prenom, int age)
        {
            this._Nom = nom;
            this._Prenom = prenom;
            this._Age = age;
        }

        public String GetIdentity()
        {
            return "Je m'appelle "+_Nom+" "+_Prenom+" j'ai "+_Age;
        }

        public void SetAge(int age)
        {
            this._Age = age;

        }

        }

}

