using Miniproject;

namespace Miniproject
{
    class MenuItem: IMenuItem
    {
        public MenuItem(string content, string title)
        {
            Content = content;
            Title = title;
        }

        public string Content {  get; set; }
        public string Title {  get; set; }

        public void Select()
        {
        }
    }
}