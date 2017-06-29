using System.Collections.Generic;
using Android.Opengl;

namespace MyXamarinAndroid.Model
{
    public class Landscape
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public static List<Landscape> GetData()
        {
            var dataList = new List<Landscape>();

            var images = GetImages();

            for(int i = 0; i < images.Length; i++)
            {
                Landscape landscape = new Landscape();
                landscape.ImageId = images[i];
                landscape.Title = "Landscape " + i;

                dataList.Add(landscape);
            }

            return dataList;
        }
        
        public static int[] GetImages()
        {
            var images = new[] { Resource.Drawable.thumb_1_0, Resource.Drawable.thumb_1_1, Resource.Drawable.thumb_1_2, Resource.Drawable.thumb_1_3,
                                 Resource.Drawable.thumb_1_4, Resource.Drawable.thumb_1_5, Resource.Drawable.thumb_1_6, Resource.Drawable.thumb_1_7,
                                 Resource.Drawable.thumb_1_8, Resource.Drawable.thumb_1_9,

                                 Resource.Drawable.thumb_2_0, Resource.Drawable.thumb_2_1, Resource.Drawable.thumb_2_2, Resource.Drawable.thumb_2_3,
                                 Resource.Drawable.thumb_2_4, Resource.Drawable.thumb_2_5, Resource.Drawable.thumb_2_6, Resource.Drawable.thumb_2_7,
                                 Resource.Drawable.thumb_2_8, Resource.Drawable.thumb_2_9,

                                 Resource.Drawable.thumb_3_0, Resource.Drawable.thumb_3_1, Resource.Drawable.thumb_3_2, Resource.Drawable.thumb_3_3,
                                 Resource.Drawable.thumb_3_4, Resource.Drawable.thumb_3_5, Resource.Drawable.thumb_3_6, Resource.Drawable.thumb_3_7,
                                 Resource.Drawable.thumb_3_8, Resource.Drawable.thumb_3_9,

                                 Resource.Drawable.thumb_4_0, Resource.Drawable.thumb_4_1, Resource.Drawable.thumb_4_2, Resource.Drawable.thumb_4_3,
                                 Resource.Drawable.thumb_4_4, Resource.Drawable.thumb_4_5, Resource.Drawable.thumb_4_6, Resource.Drawable.thumb_4_7,
                                 Resource.Drawable.thumb_4_8, Resource.Drawable.thumb_4_9,

                                 Resource.Drawable.thumb_5_0, Resource.Drawable.thumb_5_1, Resource.Drawable.thumb_5_2, Resource.Drawable.thumb_5_3,
                                 Resource.Drawable.thumb_5_4, Resource.Drawable.thumb_5_5, Resource.Drawable.thumb_5_6, Resource.Drawable.thumb_5_7,
                                 Resource.Drawable.thumb_5_8, Resource.Drawable.thumb_5_9,

                                 Resource.Drawable.thumb_6_0, Resource.Drawable.thumb_6_1, Resource.Drawable.thumb_6_2, Resource.Drawable.thumb_6_3,
                                 Resource.Drawable.thumb_6_4, Resource.Drawable.thumb_6_5, Resource.Drawable.thumb_6_6, Resource.Drawable.thumb_6_7,
                                 Resource.Drawable.thumb_6_8, Resource.Drawable.thumb_6_9,

                                 Resource.Drawable.thumb_7_0, Resource.Drawable.thumb_7_1, Resource.Drawable.thumb_7_2, Resource.Drawable.thumb_7_3,
                                 Resource.Drawable.thumb_7_4
            };

            return images;
        }
    }
}