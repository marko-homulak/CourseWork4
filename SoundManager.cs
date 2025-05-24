using System.Media;

namespace BeeBearGUI
{
    public static class SoundManager
    {
        private static SoundPlayer buzzingPlayer;
        private static SoundPlayer bearWokeUpPlayer;

        private static bool soundEnabled = false;

        public static void Initialize(bool enable)
        {
            soundEnabled = enable;

            if (!soundEnabled)
                return;

            buzzingPlayer = new SoundPlayer("sounds/buzzing.wav");
            bearWokeUpPlayer = new SoundPlayer("sounds/bear-angry.wav");
        }

        public static void StartBuzzing()
        {
            if (soundEnabled)
            {
                buzzingPlayer?.Stop(); // in case of restart
                buzzingPlayer?.PlayLooping();
            }
        }

        public static void StopBuzzing()
        {
            if (soundEnabled)
                buzzingPlayer?.Stop();
        }

        public static void PlayWokeUp()
        {
            if (soundEnabled)
                bearWokeUpPlayer?.Play();
        }

        public static void Dispose()
        {
            buzzingPlayer?.Stop();
            buzzingPlayer?.Dispose();

            bearWokeUpPlayer?.Dispose();
        }

    }
}
