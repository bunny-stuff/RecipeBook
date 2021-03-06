using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using RecipeBook.Data;

namespace RecipeBook.Models
{
    public class Step : INotifyPropertyChanged
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Image)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImageSource)));
            }
        }

        public ImageSource ImageSource => string.IsNullOrEmpty(image) ? ImageStorage.DefaultImage : image;

        public string Description { get; set; }


        public Step() 
        {
            ID = 0;
            Description = "Описание";
        }

        public Step(Step stepToCopy)
        {
            ID = stepToCopy.ID;
            Image = stepToCopy.Image;
            Description = stepToCopy.Description;
        }
    }
}
