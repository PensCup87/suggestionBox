using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace suggestionBox.Models
{
    public class SuggestionModel
    {
        //Properties - fields needed for model - only using as a template, not an object/class
        //[Key] is a data annotation that allows the next variable to be specified  as uniquie to the row 
        //have to use show potential fixes to make key work
        [Key]
        public int ID { get; set; }
        public string Topic { get; set; }
        public string Comment { get; set; }

        //anytime there is a change to the model, build the model to check for success(CTRL + SHIFT + B)

    }
}