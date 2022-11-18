using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VxFormGenerator.Core;
using VxFormGenerator.Models;

namespace VxFormGeneratorDemoData
{
    public class FeedingSession
    {
        [Display(Name = "Kind of food"), CustomValidation(typeof(FeedingSession), "IsValid", ErrorMessage = "PUTTANA")]
        public FoodKind KindOfFood { get; set; }
        [Display(Name = "Note")]
        [Required]
        public string Note { get; set; }
        [Display(Name = "Amount"), Required]
        public decimal Amount { get; set; }
        [Display(Name = "Start"), Range(typeof(DateTime), "01/01/2000", "31/12/2999", ErrorMessage = "DIOCANE")]
        public DateTime Start { get; set; }
        [Display(Name = "End")]
        public DateTime End { get; set; }
        [Display(Name = "Throwing up")]
        public bool ThrowingUp { get; set; }
        [Display(Name = "Throwing up dict")]
        public ValueReferences<FoodKind> ThrowingUpDict { get; set; } = new ValueReferences<FoodKind>();
        [Display(Name = "Color")]
        public VxColor Color { get; set; }

        public static ValidationResult IsValid(object value)
        {
            var res = new EnumDataTypeAttribute(typeof(FoodKind)) { ErrorMessage = "PUTTANA" }.IsValid(value);
            return new ValidationResult(res ? null : "PUTTANA", new []{ nameof(KindOfFood) });
        }
    }

    [Flags]
    public enum FoodKind
    {
        SOLID = 0,
        LIQUID = 1
    }
}
