using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    /// <summary>
    /// Represent what the prize is for the given place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the price
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represent a number indicate the places of team in the tournament's winning list
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Reflecting the place of teams in winning list
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represent the price amount of winnning teams
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represent the percentage of the price amount for winning teams
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
    }
}
