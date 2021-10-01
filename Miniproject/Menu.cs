namespace Miniproject
{
    class Menu : IMenuItem
    {
        public string Title { get; set; }
        private bool _running { get; set; }
        private List<MenuItem> _menuItems { get; set; }
        private MenuItem? _selectedItem { get; set; }
        private int _selectedItemIndex {  get; set; }

        public Menu(string title)
        {
            Title = title;
            _menuItems = new List<MenuItem>();
            _selectedItemIndex = 0;
        }

        public void Add(MenuItem menuItem)
        {
            _menuItems.Add(menuItem);
        }
        
        public void Start()
        {
            _running = true;
            _selectedItem = _menuItems[_selectedItemIndex];
            Console.CursorVisible = false;
            do
            {
                DrawMenu();
                HandleInput();
            } while (_running);
        }

        private void HandleInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.Backspace:
                case ConsoleKey.Escape:
                    _running = false;
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                default:
                    break;
            }
        }

        private void MoveDown()
        {
            if (_selectedItemIndex < _menuItems.Count() - 1)
            {
                _selectedItemIndex++;
            }
            else
            {
                _selectedItemIndex = 0;
            }
            _selectedItem = _menuItems[_selectedItemIndex];
        }

        private void MoveUp()
        {
            if (_selectedItemIndex > 0)
            {
                _selectedItemIndex--;
            }
            else
            {
                _selectedItemIndex = _menuItems.Count() - 1;
            }
            _selectedItem = _menuItems[_selectedItemIndex];
        }

        private void DrawMenu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            ConsoleWriteCenter(Title);
            Console.SetCursorPosition(0, Console.CursorTop + 2);

            foreach(MenuItem menuItem in _menuItems)
            {
                if (menuItem == _selectedItem)
                {
                    ConsoleWriteSelectedItem(menuItem.Title);
                }
                else
                {
                    ConsoleWriteUnselectedItem(menuItem.Title);
                }
            }
        }

        private void ConsoleWriteSelectedItem(string title)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleWriteCenter(title);
        }

        private void ConsoleWriteUnselectedItem(string title)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleWriteCenter(title);
        }

        private void ConsoleWriteCenter(string title)
        {
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
        }
    }
}