using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KeyboardCoach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool capsLockKey = false;
        string text = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            InputText.Focus();
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            text = null;
            InputText.Clear();
        }
        private void LowerCase()
        {
            //FIRST ROW
            gravis.Content = ResourceLower.gravis;
            one.Content = ResourceLower.one;
            two.Content = ResourceLower.two;
            three.Content = ResourceLower.three;
            four.Content = ResourceLower.four;
            five.Content = ResourceLower.five;
            six.Content = ResourceLower.six;
            seven.Content = ResourceLower.seven;
            eight.Content = ResourceLower.eight;
            nine.Content = ResourceLower.nine;
            zero.Content = ResourceLower.zero;
            minus.Content = ResourceLower.minus;
            equal.Content = ResourceLower.equal;
            //SECOND ROW
            q.Content = ResourceLower.q;
            w.Content = ResourceLower.w;
            ee.Content = ResourceLower.ee;
            r.Content = ResourceLower.r;
            t.Content = ResourceLower.t;
            y.Content = ResourceLower.y;
            u.Content = ResourceLower.u;
            i.Content = ResourceLower.i;
            o.Content = ResourceLower.o;
            p.Content = ResourceLower.p;
            squareBracketLeft.Content = ResourceLower.SquareBracketLeft;
            squareBracketRight.Content = ResourceLower.SquareBracketRight;
            backSlash.Content = ResourceLower.backSlash;
            //THIRD ROW
            s.Content = ResourceLower.s;
            a.Content = ResourceLower.a;
            d.Content = ResourceLower.d;
            f.Content = ResourceLower.f;
            g.Content = ResourceLower.g;
            h.Content = ResourceLower.h;
            j.Content = ResourceLower.j;
            k.Content = ResourceLower.k;
            l.Content = ResourceLower.l;
            semicolon.Content = ResourceLower.semicolon;
            upperComma.Content = ResourceLower.upperComma;
            //FOURS ROW
            z.Content = ResourceLower.z;
            x.Content = ResourceLower.x;
            c.Content = ResourceLower.c;
            v.Content = ResourceLower.v;
            b.Content = ResourceLower.b;
            n.Content = ResourceLower.n;
            m.Content = ResourceLower.m;
            comma.Content = ResourceLower.comma;
            point.Content = ResourceLower.point;
            slash.Content = ResourceLower.slash;
        }
        private void UpperCase()
        {
            //FIRST ROW
            gravis.Content = ResourceUpper.gravis;
            one.Content = ResourceUpper.one;
            two.Content = ResourceUpper.two;
            three.Content = ResourceUpper.three;
            four.Content = ResourceUpper.four;
            five.Content = ResourceUpper.five;
            six.Content = ResourceUpper.six;
            seven.Content = ResourceUpper.seven;
            eight.Content = ResourceUpper.eight;
            nine.Content = ResourceUpper.nine;
            zero.Content = ResourceUpper.zero;
            minus.Content = ResourceUpper.minus;
            equal.Content = ResourceUpper.equal;
            //SECOND ROW
            q.Content = ResourceUpper.q;
            w.Content = ResourceUpper.w;
            ee.Content = ResourceUpper.ee;
            r.Content = ResourceUpper.r;
            t.Content = ResourceUpper.t;
            y.Content = ResourceUpper.y;
            u.Content = ResourceUpper.u;
            i.Content = ResourceUpper.i;
            o.Content = ResourceUpper.o;
            p.Content = ResourceUpper.p;
            squareBracketLeft.Content = ResourceUpper.SquareBracketLeft;
            squareBracketRight.Content = ResourceUpper.SquareBracketRight;
            backSlash.Content = ResourceUpper.backSlash;
            //THIRD ROW
            s.Content = ResourceUpper.s;
            a.Content = ResourceUpper.a;
            d.Content = ResourceUpper.d;
            f.Content = ResourceUpper.f;
            g.Content = ResourceUpper.g;
            h.Content = ResourceUpper.h;
            j.Content = ResourceUpper.j;
            k.Content = ResourceUpper.k;
            l.Content = ResourceUpper.l;
            semicolon.Content = ResourceUpper.semicolon;
            upperComma.Content = ResourceUpper.upperComma;
            //FOURS ROW
            z.Content = ResourceUpper.z;
            x.Content = ResourceUpper.x;
            c.Content = ResourceUpper.c;
            v.Content = ResourceUpper.v;
            b.Content = ResourceUpper.b;
            n.Content = ResourceUpper.n;
            m.Content = ResourceUpper.m;
            comma.Content = ResourceUpper.comma;
            point.Content = ResourceUpper.point;
            slash.Content = ResourceUpper.slash;
        }
        private void UpperCaseCapsLock()
        {
            //FIRST ROW
            gravis.Content = ResourceLower.gravis;
            one.Content = ResourceLower.one;
            two.Content = ResourceLower.two;
            three.Content = ResourceLower.three;
            four.Content = ResourceLower.four;
            five.Content = ResourceLower.five;
            six.Content = ResourceLower.six;
            seven.Content = ResourceLower.seven;
            eight.Content = ResourceLower.eight;
            nine.Content = ResourceLower.nine;
            zero.Content = ResourceLower.zero;
            minus.Content = ResourceLower.minus;
            equal.Content = ResourceLower.equal;
            //SECOND ROW
            q.Content = ResourceUpper.q;
            w.Content = ResourceUpper.w;
            ee.Content = ResourceUpper.ee;
            r.Content = ResourceUpper.r;
            t.Content = ResourceUpper.t;
            y.Content = ResourceUpper.y;
            u.Content = ResourceUpper.u;
            i.Content = ResourceUpper.i;
            o.Content = ResourceUpper.o;
            p.Content = ResourceUpper.p;
            squareBracketLeft.Content = ResourceUpper.SquareBracketLeft;
            squareBracketRight.Content = ResourceUpper.SquareBracketRight;
            backSlash.Content = ResourceUpper.backSlash;
            //THIRD ROW
            s.Content = ResourceUpper.s;
            a.Content = ResourceUpper.a;
            d.Content = ResourceUpper.d;
            f.Content = ResourceUpper.f;
            g.Content = ResourceUpper.g;
            h.Content = ResourceUpper.h;
            j.Content = ResourceUpper.j;
            k.Content = ResourceUpper.k;
            l.Content = ResourceUpper.l;
            semicolon.Content = ResourceUpper.semicolon;
            upperComma.Content = ResourceUpper.upperComma;
            //FOURS ROW
            z.Content = ResourceUpper.z;
            x.Content = ResourceUpper.x;
            c.Content = ResourceUpper.c;
            v.Content = ResourceUpper.v;
            b.Content = ResourceUpper.b;
            n.Content = ResourceUpper.n;
            m.Content = ResourceUpper.m;
            comma.Content = ResourceUpper.comma;
            point.Content = ResourceUpper.point;
            slash.Content = ResourceUpper.slash;
        }
        private void LowerCaseCapsLock()
        {
            //FIRST ROW
            gravis.Content = ResourceUpper.gravis;
            one.Content = ResourceUpper.one;
            two.Content = ResourceUpper.two;
            three.Content = ResourceUpper.three;
            four.Content = ResourceUpper.four;
            five.Content = ResourceUpper.five;
            six.Content = ResourceUpper.six;
            seven.Content = ResourceUpper.seven;
            eight.Content = ResourceUpper.eight;
            nine.Content = ResourceUpper.nine;
            zero.Content = ResourceUpper.zero;
            minus.Content = ResourceUpper.minus;
            equal.Content = ResourceUpper.equal;
            //SECOND ROW
            q.Content = ResourceLower.q;
            w.Content = ResourceLower.w;
            ee.Content = ResourceLower.ee;
            r.Content = ResourceLower.r;
            t.Content = ResourceLower.t;
            y.Content = ResourceLower.y;
            u.Content = ResourceLower.u;
            i.Content = ResourceLower.i;
            o.Content = ResourceLower.o;
            p.Content = ResourceLower.p;
            squareBracketLeft.Content = ResourceLower.SquareBracketLeft;
            squareBracketRight.Content = ResourceLower.SquareBracketRight;
            backSlash.Content = ResourceLower.backSlash;
            //THIRD ROW
            s.Content = ResourceLower.s;
            a.Content = ResourceLower.a;
            d.Content = ResourceLower.d;
            f.Content = ResourceLower.f;
            g.Content = ResourceLower.g;
            h.Content = ResourceLower.h;
            j.Content = ResourceLower.j;
            k.Content = ResourceLower.k;
            l.Content = ResourceLower.l;
            semicolon.Content = ResourceLower.semicolon;
            upperComma.Content = ResourceLower.upperComma;
            //FOURS ROW
            z.Content = ResourceLower.z;
            x.Content = ResourceLower.x;
            c.Content = ResourceLower.c;
            v.Content = ResourceLower.v;
            b.Content = ResourceLower.b;
            n.Content = ResourceLower.n;
            m.Content = ResourceLower.m;
            comma.Content = ResourceLower.comma;
            point.Content = ResourceLower.point;
            slash.Content = ResourceLower.slash;
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.CapsLock && capsLockKey == false)
            {
                capsLockKey = true;
                UpperCaseCapsLock();
            }
            else if (e.Key == Key.CapsLock && capsLockKey == true)
            {
                capsLockKey = false;
                LowerCase();
            }
            else if (e.Key == Key.LeftShift && capsLockKey == false || e.Key == Key.RightShift && capsLockKey == false) UpperCase();
            else if (e.Key == Key.LeftShift && capsLockKey == true || e.Key == Key.RightShift && capsLockKey == true) LowerCaseCapsLock();

            if (e.Key == Key.Enter)
            {
                Enter.Visibility = Visibility.Collapsed;
                StopBtn_Click(sender, e);
                Start.Focus();
            }
            else if (e.Key == Key.Tab) Tab.Visibility = Visibility.Collapsed;
            else if (e.Key == Key.Back) Backspace.Visibility = Visibility.Hidden;
            else if (e.Key == Key.LeftShift) shiftLeft.Visibility = Visibility.Collapsed;
            else if (e.Key == Key.RightShift) shiftRight.Visibility = Visibility.Collapsed;
            else if (e.Key == Key.RightCtrl) controlRight.Visibility = Visibility.Collapsed;
            else if (e.Key == Key.LeftCtrl) controlLeft.Visibility = Visibility.Collapsed;
            else if (e.Key == Key.LeftAlt) altLeft.Visibility = Visibility.Collapsed;
            else if (e.Key == Key.RightAlt) altRight.Visibility = Visibility.Collapsed;
            else if (e.Key == Key.Space) space.Visibility = Visibility.Hidden;
            return;
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            ReturnChanging();
            if (e.Key == Key.LeftShift && capsLockKey == false || e.Key == Key.RightShift && capsLockKey == false) LowerCase();
            else if (e.Key == Key.LeftShift && capsLockKey == true || e.Key == Key.RightShift && capsLockKey == true) UpperCaseCapsLock();
            if (e.Key == Key.Tab) Tab.Visibility = Visibility.Visible;
            else if (e.Key == Key.Enter) Enter.Visibility = Visibility.Visible;
            else if (e.Key == Key.Back) Backspace.Visibility = Visibility.Visible;
            else if (e.Key == Key.LeftShift) shiftLeft.Visibility = Visibility.Visible;
            else if (e.Key == Key.RightShift) shiftRight.Visibility = Visibility.Visible;
            else if (e.Key == Key.RightCtrl) controlRight.Visibility = Visibility.Visible;
            else if (e.Key == Key.LeftCtrl) controlLeft.Visibility = Visibility.Visible;
            else if (e.Key == Key.LeftAlt) altLeft.Visibility = Visibility.Visible;
            else if (e.Key == Key.RightAlt) altRight.Visibility = Visibility.Visible;
            else if (e.Key == Key.Space) space.Visibility = Visibility.Visible;
            return;
        }

        private void Input_KeyDown(object sender, TextCompositionEventArgs e)
        {
            InputText.Text += e.Text;
            return;
        }
        private void ButtonCheck(string text)
        {
            foreach (var item in buttonsGrid.Children.OfType<Grid>().Where(g => g.Children.Count <= 15))
            {
                foreach (var button in item.Children.OfType<Button>())
                {
                    if (button.Content.ToString() == text)
                    {
                        button.Visibility = Visibility.Hidden;
                        return;
                    }
                }
            }
        }

        private void Input_textChange(object sender, TextChangedEventArgs e)
        {
            if (InputText.Text != "") 
                text = InputText.Text.Substring(InputText.Text.Length - 1);
            if (text != null) ButtonCheck(text);
        }
        private void ReturnChanging()
        {
            if (!string.IsNullOrEmpty(InputText.Text))
            {
                foreach (var item in buttonsGrid.Children.OfType<Grid>().Where(g => g.Children.Count <= 15))
                {
                    foreach (var button in item.Children.OfType<Button>())
                    {
                        if (button.Content.ToString() == text)
                        {
                            button.Visibility = Visibility.Visible;
                            return;
                        }
                    }
                }
            }
        }
    }
}
