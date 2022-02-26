using System.Collections;

namespace MouseTrap
{
    public class ScreenWrapperList : ICollection<ScreenWrapper>, IList<ScreenWrapper>, IEnumerable<ScreenWrapper>, IEnumerable, IReadOnlyCollection<ScreenWrapper>, IReadOnlyList<ScreenWrapper>, ICollection, IList
    {
        private readonly List<ScreenWrapper> _list;

        public ScreenWrapperList()
        {
            _list = new();
            foreach (Screen scr in Screen.AllScreens)
            {
                _list.Add(new(scr));
            }
        }

        public ScreenWrapper this[int index] { get => ((IList<ScreenWrapper>)_list)[index]; set => ((IList<ScreenWrapper>)_list)[index] = value; }
        object? IList.this[int index] { get => ((IList)_list)[index]; set => ((IList)_list)[index] = value; }

        public int Count => ((ICollection<ScreenWrapper>)_list).Count;

        public bool IsReadOnly => ((ICollection<ScreenWrapper>)_list).IsReadOnly;

        public bool IsSynchronized => ((ICollection)_list).IsSynchronized;

        public object SyncRoot => ((ICollection)_list).SyncRoot;

        public bool IsFixedSize => ((IList)_list).IsFixedSize;

        public void Add(ScreenWrapper item)
        {
            ((ICollection<ScreenWrapper>)_list).Add(item);
        }

        public int Add(object? value)
        {
            return ((IList)_list).Add(value);
        }

        public void Clear()
        {
            ((ICollection<ScreenWrapper>)_list).Clear();
        }

        public bool Contains(ScreenWrapper item)
        {
            return ((ICollection<ScreenWrapper>)_list).Contains(item);
        }

        public bool Contains(object? value)
        {
            return ((IList)_list).Contains(value);
        }

        public void CopyTo(ScreenWrapper[] array, int arrayIndex)
        {
            ((ICollection<ScreenWrapper>)_list).CopyTo(array, arrayIndex);
        }

        public void CopyTo(Array array, int index)
        {
            ((ICollection)_list).CopyTo(array, index);
        }

        public IEnumerator<ScreenWrapper> GetEnumerator()
        {
            return ((IEnumerable<ScreenWrapper>)_list).GetEnumerator();
        }

        public int IndexOf(ScreenWrapper item)
        {
            return ((IList<ScreenWrapper>)_list).IndexOf(item);
        }

        public int IndexOf(object? value)
        {
            return ((IList)_list).IndexOf(value);
        }

        public void Insert(int index, ScreenWrapper item)
        {
            ((IList<ScreenWrapper>)_list).Insert(index, item);
        }

        public void Insert(int index, object? value)
        {
            ((IList)_list).Insert(index, value);
        }

        public bool Remove(ScreenWrapper item)
        {
            return ((ICollection<ScreenWrapper>)_list).Remove(item);
        }

        public void Remove(object? value)
        {
            ((IList)_list).Remove(value);
        }

        public void RemoveAt(int index)
        {
            ((IList<ScreenWrapper>)_list).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}
