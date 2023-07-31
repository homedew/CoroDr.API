using System;
using System.Collections.Generic;

namespace Catalog.API.Models;

public partial class CatalogBrand
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<CatalogList> CatalogLists { get; set; } = new List<CatalogList>();
}
