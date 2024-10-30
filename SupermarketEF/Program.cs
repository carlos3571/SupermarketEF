using SupermarketEF.Data;
using SupermarketEF.Models;



    using SupermarketContext context = new SupermarketContext();


    // Se crea objeto oilCategory de tipo Category
    Category oilCategory = new Category()

    {
        Name = "Oil",
        Description = "Oil Category"
    };

    // Se agrega el objeto creado al contexto de la DB
    // Usando la propieda Categories del contxto

    context.Categories.Add(oilCategory);

    // Se crea el objeto grainsCategory de tipo Category
    Category grainsCategory = new Category()
    {

        Name = "Grains",
        Description = "Grains Category"
    };

    // Se agrega el objeto crado al contexto de la DB
    context.Add(grainsCategory);

    // Se graban los cambios reaizados en el contexto
    context.SaveChanges();

    // Recupera todas las categorias y las ordena por nombre
    var categories = context.Categories.OrderBy(p => p.Name);
    foreach (var category in categories)
    {
        Console.WriteLine($"{category.Name} | {category.Description}");
    }



/*
var grainCategory = context.Categories.Where(p => p.Name == "Grains").FirstOrDefault();

if (grainCategory is Category)
{
    grainCategory.Description = "New description applied";
    context.Remove(grainCategory); // Borra registro
}

context.SaveChanges();

var categories = context.Categories.OrderBy(p => p.Name);

foreach (var category in categories)
{
    Console.WriteLine($"{category.Name} | {category.Description}");
}

*/