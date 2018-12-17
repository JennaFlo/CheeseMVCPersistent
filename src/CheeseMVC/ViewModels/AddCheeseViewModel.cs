using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.ViewModels;
using CheeseMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")]
        public string Description { get; set; }

        //public CheeseCategory Category { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public AddCheeseViewModel() { }
        //!!!I still need to add the CategoryID and the SaveChangesError to this!!!
        //Also need to fix error" doesnot contain constructor that takes 1 arguement

        public AddCheeseViewModel(IEnumerable<CheeseCategory> categories)
        {
            Categories = new List<SelectListItem>();

            // <option value="0">Hard</option>
            foreach (CheeseCategory category in categories)
            {

                Categories.Add(new SelectListItem
                {
                    Value = category.ID.ToString(),
                    Text = category.Name
                });
            }
        }

        /*CheeseTypes.Add(new SelectListItem
        {
            Value = ((int)CheeseCategory.Soft).ToString(),
            Text = CheeseCategory.Soft.ToString()
        });

        CheeseTypes.Add(new SelectListItem
        {
            Value = ((int)CheeseCategory.Fake).ToString(),
            Text = CheeseCategory.Fake.ToString()
        });

    }
}*/
    }
}
