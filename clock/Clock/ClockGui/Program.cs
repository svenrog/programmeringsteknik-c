using Mono.Terminal;
using System;
using Terminal.Gui;

namespace ClockGui
{
    class Program
    {
        static Label _label;
        static Toplevel _topLevel;
        static object _timeout;
        static TimeSpan _updateInterval = TimeSpan.FromMilliseconds(16); // ~ 60 fps

        static void Main(string[] args)
        {
            Application.Init();

            CreateUi();

            Application.Run(_topLevel);
        }

        static void CreateUi()
        {
            _label = CreateCenteredLabel();
            _topLevel = CreateTopLevel();
            _topLevel.Add(_label);

            _timeout = Application.MainLoop.AddTimeout(_updateInterval, UpdateTimer);
        }

        static Toplevel CreateTopLevel()
        {
            return new Toplevel()
            {
                X = 0,
                Y = 0,
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };
        }

        static Label CreateCenteredLabel()
        {
            return new Label(GetTimerText())
            {
                X = Pos.Center(),
                Y = Pos.Center(),
                Width = Dim.Sized(24),
                Height = Dim.Sized(3),
            };
        }

        static bool UpdateTimer(MainLoop loop)
        {
            _label.Text = GetTimerText();
            return true;
        }

        static string GetTimerText()
        {
            return DateTime.Now.ToString("\n yyyy-MM-dd HH\\:mm\\:ss.FF ");
        }
    }
}
