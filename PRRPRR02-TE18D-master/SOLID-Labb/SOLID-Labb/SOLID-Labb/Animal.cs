﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    public abstract class Animal
    {
        string _owner;
        public string _color;

        public Animal(string color)
        {
            _color = color;
        }

        public abstract void Speak();

        public abstract void Sleep();

        public abstract void Eat();

        public void TransferOwnership(string owner)
        {
            _owner = owner;
        }
    }
}