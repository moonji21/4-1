
namespace task_4_1
{
    public class OneDims<T> 
    {
        private T[] massive;
        private Random random = new Random();
        private int size1;
        private int cap1;


        public OneDims(int capacity = 7)
        {
            massive = new T[capacity];
            cap1 = capacity;
            size1 = 0;        
        }
       
       public void AddEl(T el)
       {
        if(size1 >= cap1)
        {
            cap1 = 2 * cap1 + 1;
            T[] massn =  new T[cap1];
            Array.Copy(massive, massn, size1);
            massive = massn;
        }
        massive[size1] = el;
        size1++;
       }

       public void Print()
       {
        Console.WriteLine("Массив: ");
        for (int i = 0; i < size1; i++)
        {
            Console.Write(massive[i] + " ");
        }
        Console.WriteLine();
       }

    public void DelEl(int ind)
    {

        if(ind <= size1)
        {
            T[] massn = new T[cap1];
            for(int i = 0; i < size1; i++)
            {
                if(i != ind)
                {
                    massn[i] = massive[i];
                }
            } 
            size1--;
            massive = massn;        
       }

       else
       {
        Console.WriteLine("Индекс за пределами диапозона. ");
       }
       
    }

    public void Sortt()
    {
        Array.Sort(massive, 0, size1);
    }

    public bool IsElInMass(T el)
        {
            if(massive.Contains(el))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CountIf(Func < T,bool> act)
        {
            int c = 0;
            for(int i = 0; i< size1; i++)
            {
                if(act(massive[i]))
                {
                    c++;                                                                                                                                                              
                }
            }
            return c;
        }

        public bool IfOne(Func < T, bool > act)
        {
            for (int i = 0; i < size1; i++)
            {
                if (act(massive[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IfAll(Func < T, bool > act)
        {
            for (int i = 0; i < size1; i++)
            {
                if (!act(massive[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public void ToAll(Func < T, T > act)
        {
            for(int i = 0; i < size1; i++)
            {
                massive[i] = act(massive[i]);
            }
        }

        public void Invert()
        {
            var buf = new T[size1];
            int c = 0;
            for (int i =0; i<size1; i++)
            {
                buf[c] = massive[i];
                c++;
            }
            massive = buf;
        }

        public T Min()
        {
            T[] values = new T[size1];
            for (int i = 0; i < size1; i++)
            {
                values[i] = massive[i];
            }
            Array.Sort(values);
            return values[0];
        }

        public T Max()
        {
            T[] values = new T[size1];
            for (int i = 0; i < size1; i++)
            {
                values[i] = massive[i];
            }
            Array.Sort(values);
            return values[size1 -1];
        }   

    }
}