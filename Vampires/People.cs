using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Vampires
{
    public class People
    {
        private string Name;
        private bool Sex;
        private double Panic;
        private double Weakness;
        private Room Place;
        private bool IsHealed;
        private int ContactTime;
        private string[] Answer;

        public People(string name, bool sex, double weakness, Room place, string[] answer)
        {
            Name = name;
            Sex = sex;
            Panic = 0.00d;
            Weakness = weakness;
            Place = place;
            IsHealed = false;
            ContactTime = 0;
            Answer = answer;
        }
        public People(string name, bool sex, double weakness, Room place, bool isHealed, string[] answer)
        {
            Name = name;
            Sex = sex;
            Panic = 0.00d;
            Weakness = weakness;
            Place = place;
            IsHealed = isHealed;
            ContactTime = 0;
            Answer = answer;

        }
        public string GetName() => Name;
        public bool GetSex() => Sex;
        public double GetPanic() => Panic;
        public void SetPanic(double panic) => Panic = panic;
        public double GetWeakness() => Weakness;
        public void SetWeakness(double weakness) => Weakness = weakness;
        public Room GetPlace() => Place;
        public void SetRoom(Room place) => Place = place;
        public bool GetIsHealed() => IsHealed;
        public int GetContactTime() => ContactTime;
        public void SetContactTime(int contactTime) => ContactTime = contactTime;
        public string[] GetAnswer() => Answer;
        public void Move(Room room) => Place = room;

        public void Kill(People ppl)
        {
            ppl = null;
        }
        
    }
}
