using MVCExercise.Models;
using MVCExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCExercise.Services
{
    public class ColorService
    {         
        private readonly string _apiURL = "https://reqres.in/api/example?per_page=2&page=";

        public List<ColorViewModel> PopulateColorList()
        {
            var allColorsUnsorted = GetAllColors();
            var sortedColorsViewModels = SortColorsIntoGroups(allColorsUnsorted);
            var orderedColorsViewModelsList = sortedColorsViewModels.OrderBy(o => o.Year).ToList();

            return orderedColorsViewModelsList;
        }
        public List<Color> GetAllColors()
        {
            var allColors = new List<Color>();

            for (int i = 0; i < 6; i++)
            {
                var colorListFromApi = GetColorsOnPage(i);
                allColors.AddRange(colorListFromApi);
            }
            
            return allColors;
        }
        public List<Color> GetColorsOnPage(int pageNo)
        {
            var result = ApiHelper.Instance
                .MakeApiCallSync($"{_apiURL}{pageNo}", new List<Color>()
                    .GetType());
            return result;
        }

        public List<ColorViewModel> SortColorsIntoGroups(List<Color> allColorsUnsorted)
        {
            var allColorViewModels = new List<ColorViewModel>();

            foreach (var color in allColorsUnsorted)
            {
                var model = new ColorViewModel()
                {
                    Id = color.Id,
                    Name = color.Name,
                    Year = color.Year,
                    ColorHex = color.ColorHex,
                    PantoneValue = color.PantoneValue
                };             

                string[] pantoneValues = color.PantoneValue.Split('-');
                var pantoneValue = Convert.ToInt32(pantoneValues[0]);
                               
                if ((pantoneValue % 3) == 0)
                {
                    model.GroupNo = 1;
                }
                else if ((pantoneValue % 2) == 0)
                {
                    model.GroupNo = 2;
                }
                else
                {
                    model.GroupNo = 3;
                }
                allColorViewModels.Add(model);
            }
            return allColorViewModels;
        }    
    }
}
