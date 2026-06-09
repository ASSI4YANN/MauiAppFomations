using Microsoft.AspNetCore.Mvc;

namespace APIFomations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategorieController : ControllerBase
    {

        private readonly ILogger<CategorieController> _logger;

        public CategorieController(ILogger<CategorieController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCategorie")]
        public IEnumerable<Categorie> Get()
        {
            Categorie[] Categories =
                {
                       new Categorie ("Dévelopement",10,"Apprenez le developpemrnt informatique.","icon_dev.png"),
                       new Categorie ("Design",20,"Créer vos maquettes et logos","icon_cible.png"),
                       new Categorie ("Business",24,"Lancez vos business","icon_dev.png"),
                       new Categorie ("Gestion",16,"La gestion de projets","icon_gestion.png"),
                       new Categorie ("Bureautique",2,"Word, PowerPoint, Excel","icon_ppt.png"),
                       new Categorie ("Photo",8,"La retouche photo","icon_photo.png"),
                       new Categorie ("Vidéo",18,"La montage vidéo","icon_video.png"),
                       new Categorie ("3D",28,"Création de jeux","icon_modelisation.png")                 
                       };
            return Categories;

        }
    }
}
