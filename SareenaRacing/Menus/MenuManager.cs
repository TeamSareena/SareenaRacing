namespace SareenaRacing
{

    public static class MenuManager
    {
        public static bool mainMenuOn;
        public static bool endGameMenuOn;
        public static bool gameStartOn;

        //switching between menus

        public static void TurnOtherMenusOff()
        {
            if (mainMenuOn)
            {
                endGameMenuOn = false;
                gameStartOn = false;
            }
            if (endGameMenuOn)
            {
                mainMenuOn = false;
                gameStartOn = false;
            }
            if (gameStartOn)
            {
                mainMenuOn = false;
                endGameMenuOn = false;
            }
        }
    }
}
