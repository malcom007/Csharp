using System.Collections;
using System.Collections.Generic;

namespace LabCours3OminiPop
{
    internal class ArrayList<T> : IList<etudiant>
    {
        etudiant IList<etudiant>.this[int index] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        int ICollection<etudiant>.Count => throw new System.NotImplementedException();

        bool ICollection<etudiant>.IsReadOnly => throw new System.NotImplementedException();

        void ICollection<etudiant>.Add(etudiant item)
        {
            throw new System.NotImplementedException();
        }

        void ICollection<etudiant>.Clear()
        {
            throw new System.NotImplementedException();
        }

        bool ICollection<etudiant>.Contains(etudiant item)
        {
            throw new System.NotImplementedException();
        }

        void ICollection<etudiant>.CopyTo(etudiant[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        IEnumerator<etudiant> IEnumerable<etudiant>.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        int IList<etudiant>.IndexOf(etudiant item)
        {
            throw new System.NotImplementedException();
        }

        void IList<etudiant>.Insert(int index, etudiant item)
        {
            throw new System.NotImplementedException();
        }

        bool ICollection<etudiant>.Remove(etudiant item)
        {
            throw new System.NotImplementedException();
        }

        void IList<etudiant>.RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }
    }
}