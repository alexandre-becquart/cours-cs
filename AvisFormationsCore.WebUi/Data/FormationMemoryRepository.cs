using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data
{
    public class FormationMemoryRepository
    {
        private List<Formation> _formations = new List<Formation>();

        public FormationMemoryRepository()
        {
            _formations.Add(new Formation { Id = 1, Nom = "Créer votre site web avec ASP.NET CORE", NomSeo = "asp-net-core", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sollicitudin malesuada massa, quis mollis lorem tempor quis. Integer fringilla lacus eget libero pulvinar luctus." });
            _formations.Add(new Formation { Id = 2, Nom = "Créer votre site web avec PHP", NomSeo = "php", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sollicitudin malesuada massa, quis mollis lorem tempor quis. Integer fringilla lacus eget libero pulvinar luctus." });
            _formations.Add(new Formation { Id = 3, Nom = "Devenez un pro du jardinage", NomSeo = "pro-jardinage", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sollicitudin malesuada massa, quis mollis lorem tempor quis. Integer fringilla lacus eget libero pulvinar luctus." });
            _formations.Add(new Formation { Id = 4, Nom = "Photo Pro", NomSeo = "photo-pro", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sollicitudin malesuada massa, quis mollis lorem tempor quis. Integer fringilla lacus eget libero pulvinar luctus." });

        }

        public Formation GetFormationById(int iIdFormation)
        {
            // Sans linq

            //foreach(var f in _formations)
            //{
            //    if(f.Id == iIdFormation)
            //    {
            //        return f;
            //    }
            //}
            // return null;

            // Avec linq 1er méthode

            //return _formations.Where(f => f.Id == iIdFormation).FirstOrDefault();

            // Avec Linq 2eme méthode

            return _formations.FirstOrDefault(f => f.Id == iIdFormation);
        }

        public List<Formation> GetAllFormations()
        {
            return _formations;
        }
    }
}
