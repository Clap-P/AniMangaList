
namespace AniMangaList.Models
{
    internal class StringLenghtAttribute : Attribute
    {
        private int v;
        private int minimumLenght;

        public StringLenghtAttribute(int v, int MinimumLenght)
        {
            this.v = v;
            minimumLenght = MinimumLenght;
        }
    }
}