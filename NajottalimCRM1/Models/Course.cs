﻿namespace NajottalimCRM1.Models
{
    public class Course
    {
        public int course_id { get; set; }
        public string course_name {  get; set; }
        public int teacher_id { get;set; }
        public string duration {  get; set; }
        public string price {  get; set; }
        public string description { get; set; }
        public int studdents_count {  get; set; }

    }
}
