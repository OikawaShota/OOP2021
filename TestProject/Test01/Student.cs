namespace Test01 {
    class Student {
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }

        public Student(string name,string subject,int score) {
            this.Name = name;
            this.Subject = subject;
            this.Score = score;
        }


    }
}
