namespace Program
{
    class Indexers
    {
        private Dictionary<string, string> _dict;

        public string[] arr = new string[5];

        public Indexers(){
            _dict = new Dictionary<string, string>();
        }


        public string this[string key]{
            get{
                return _dict[key];
            }
            set{
                _dict[key] = value;
            }
        }

        public string this[int i]{
            get{
                return arr[i];
            }
            set{
                arr[i] = value;
            }
        }

    }
}
