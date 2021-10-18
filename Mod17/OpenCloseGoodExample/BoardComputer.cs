using System;
using OpenCloseGoodExample.Profiles;

namespace OpenCloseGoodExample
{
    class BoardComputer
    {
        /// <summary>
        /// Запускает посадку
        /// Загружает профиль в виде аргумента
        /// </summary>
        public void PerformLanding( ILandingProfile landingProfile )
        {
            landingProfile.Execute();
        }
    }
}