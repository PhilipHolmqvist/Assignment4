using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib
{

    public class ListManager<T> : IListManager<T>
    {

        private List<T> m_List;

        int IListManager<T>.Count => Count();

        public ListManager()
        {
            this.m_List = new List<T>();
     
        }

        public int Count()
        {
            return this.m_List.Count;
        }

        public Boolean shuffleItemsInList()
        {
          
            Random rng = new Random();

            int n = m_List.Count;
            while(n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = m_List[k];
                m_List[k] = m_List[n];
                m_List[n] = value;
            }

            return true;
        }

        //Adds an object to the end of the list.
        public bool Add(T aType)
        {
            if(aType != null)
            {
                m_List.Add(aType); 
                return true;
            }

            return false;
        }

        //Change the object at certain position. 
        public bool ChangeAt(T aType, int anIndex)
        {
            if(aType != null && anIndex >= 0)
            {
                m_List[anIndex] = aType;
                return true;
            }
            return false;
            
        }

        //Check if the index has a object in the list
        public bool CheckIndex(int index)
        {
           if(index >= 0)
            {
                T aType = m_List[index];
                if(aType != null)
                {
                    return true;
                }
            }
            return false;
        }

        //Deletes all objects in the list
        public void DeleteAll()
        {
            m_List.Clear();
        }

        //Deletes a object in a ceratin position.
        public bool DeleteAt(int anIndex)
        {
            if (anIndex >= 0)
            {
                m_List.RemoveAt(anIndex);
                return true;
            }
            return false;
        }

        //Retrives the object at the given index.
        public T GetAt(int anIndex)
        {
             T aType = m_List[anIndex]; 
             return aType;
               
            }

        //Returns a List<string> of all the objects.
        public List<string> ToStringList()
        {
            List<string> list = new List<string>();
            for(int i = 0; i < m_List.Count; i++)
            {
                list.Add(m_List[i].ToString());
            }
            return list;
        }

        //Returns an array of strings of all the objects.
        public string[] ToStringArray()
        {
            string[] strings = new string[m_List.Count];
            for (int i = 0; i < m_List.Count; i++)
            {
                strings[i] = m_List[i].ToString();
            }
            return strings;
        }
    }
}
