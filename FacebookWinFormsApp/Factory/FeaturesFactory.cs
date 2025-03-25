using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Factory
{
    public enum eFeatureType
    {
        MatchMaker,
        GreatestOfTheYear,
    }

    public static class FeaturesFactory
    {
        public static IFacebookFeature CreateFeature(eFeatureType i_FeatureType)
        {
            IFacebookFeature result;

            switch (i_FeatureType)
            {
                case eFeatureType.MatchMaker:
                    result =  new MatchFeature();
                    break;
                case eFeatureType.GreatestOfTheYear:
                    result =  new GreatestOfTheYearFeature();
                    break;
                default:
                    throw new ArgumentException("Invalid feature type");
            }

            return result;
        }
    }
}
