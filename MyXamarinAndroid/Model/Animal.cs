using System.Collections.Generic;

namespace MyXamarinAndroid.Model
{
    public class Animal
    {
        public string Title { get; set; }
        public int ImageId { get; set; }

        public static List<Animal> GetData()
        {
            var data = new List<Animal>();

            var images = new[]
            {
                Resource.Drawable.ani_cat_one,
                Resource.Drawable.ani_cat_two,
                Resource.Drawable.ani_cat_three,
                Resource.Drawable.ani_cat_four,
                Resource.Drawable.ani_cat_five,
                Resource.Drawable.ani_cat_six,
                Resource.Drawable.ani_cat_seven,

                Resource.Drawable.ani_dog_one,
                Resource.Drawable.ani_dog_two,
                Resource.Drawable.ani_dog_three,
                Resource.Drawable.ani_dog_four,
                Resource.Drawable.ani_dog_five,

                Resource.Drawable.ani_deer_one,
                Resource.Drawable.ani_deer_two,
                Resource.Drawable.ani_deer_three,
                Resource.Drawable.ani_deer_four,

                Resource.Drawable.bird_parrot_one,
                Resource.Drawable.bird_parrot_two,
                Resource.Drawable.bird_parrot_three,
                Resource.Drawable.bird_parrot_four,
                Resource.Drawable.bird_parrot_five,
                Resource.Drawable.bird_parrot_six,
                Resource.Drawable.bird_parrot_seven,
                Resource.Drawable.bird_parrot_eight
            };

            var categories = new []
            {
                "Cat 1", "Cat 2", "Cat 3", "Cat 4", "Cat 5", "Cat 6", "Cat 7",
                "Dog 1", "Dog 2", "Dog 3", "Dog 4", "Dog 5",
                "Deer 1", "Deer 2", "Deer 3", "Deer 4",
                "Parrot 1", "Parrot 2", "Parrot 3", "Parrot 4", "Parrot 5", "Parrot 6", "Parrot 7", "Parrot 8"
            };

            for (int i = 0; i < images.Length; i++)
            {
                var current = new Animal();
                current.Title = categories[i];
                current.ImageId = images[i];
                data.Add(current);
            }

            return data;
        }
    }
}