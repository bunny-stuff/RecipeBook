﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using RecipeBook.Models;
using System.Linq;
using System.ComponentModel;

namespace RecipeBook
{
    public class Recipe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int ID { get; set; }

        private string image;
        public string Image 
        {
            get => image;
            set
            {
                image = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Image"));
            }
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public ObservableCollection<Step> Steps { get; set; } = new ObservableCollection<Step>();


        public Recipe() { }

        public Recipe(Recipe recipeToCopy)
        {
            ID =  recipeToCopy.ID;
            Image = recipeToCopy.Image;
            Title = recipeToCopy.Title;
            Description = recipeToCopy.Description;
            Steps = new ObservableCollection<Step>(recipeToCopy.Steps.Select(x => new Step(x)));
        }
    }
}
