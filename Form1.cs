namespace Project
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

      public void loadGame(object sender, EventArgs e)
        {
            GameScreen gameScreen = new GameScreen();

            gameScreen.Show();
            this.Hide();
        }   

        private void howTo(object sender, EventArgs e)
        {
            hoToPlay howTo = new hoToPlay();

            howTo.Show ();
            this.Hide();        
        }
    }
}