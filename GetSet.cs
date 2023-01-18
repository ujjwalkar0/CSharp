namespace Program{
    class GetSet{
        public DateTime birthday{get; private set;}

        public GetSet(DateTime birthday){
            this.birthday = birthday;
        }

        public int getAge{
            get{
                return DateTime.Today.Year-birthday.Year;
            }
        }
    }
}