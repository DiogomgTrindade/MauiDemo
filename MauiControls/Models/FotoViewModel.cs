using MauiControls.NewFolder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
    public class FotoViewModel
    {
        public ObservableCollection<Foto> fotos { get; private set; }

        public ObservableCollection<Foto> Fotos
        {
            get { return fotos; }
            set { fotos = value; } 
        }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                //new Foto() {Nome="Andrômeda", ImagemUrl="Andromeda.Galaxy.jpg"},
                new Foto() {Nome="Via Láctea", ImagemUrl="galaxia2.jpg"},
                new Foto() {Nome="Universo", ImagemUrl="galaxia3.jpg"},
                new Foto() {Nome="Galáxia", ImagemUrl="galaxia4.jpg"},
                new Foto() {Nome="Sombrero", ImagemUrl="galaxia5.jpg"},
            };
        }



    }
}
