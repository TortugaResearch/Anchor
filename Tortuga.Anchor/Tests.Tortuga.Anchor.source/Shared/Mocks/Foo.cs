using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Tests.Mocks
{
    public class Foo : INotifyPropertyChanged
    {
        private string m_FooBar;
        private readonly Collection<Bar> m_Bars = new Collection<Bar>();

        public Collection<Bar> Bars
        {
            get { return m_Bars; }
        }

        public string FooBar
        {
            get { return m_FooBar; }
            set
            {
                if (m_FooBar == value)
                    return;

                m_FooBar = value;

                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("FooBar"));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
