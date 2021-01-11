using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundShooter
{
    /// <summary>
    /// いわゆるオブジェクトプール
    /// </summary>
    public class ListBuffer<T> : IDisposable
    {
        //===============================================
        // Field
        //===============================================
        private List<T> m_freeList = new List<T>(); // 空き
        private List<T> m_useList = new List<T>(); // 使用中
        private Func<T> m_onAlloc = default;

        //===============================================
        // Property
        //===============================================

        //===============================================
        // Method
        //===============================================

        public ListBuffer(Func<T> onAlloc)
        {
            m_onAlloc = onAlloc;
        }

        /// <summary>
        /// 返却
        /// </summary>
        public void Free(T obj)
        {
            if (m_useList.Contains(obj))
            {
                m_freeList.Add(obj);
                m_useList.Remove(obj);
            }
        }

        /// <summary>
        /// 取得
        /// </summary>
        public T Alloc()
        {
            if (m_freeList.Count > 0)
            {
                // 空きがあるならそこから取り出す
                var obj = m_freeList.ElementAt(m_freeList.Count - 1);
                m_freeList.RemoveAt( m_freeList.Count - 1 );
                m_useList.Add( obj );
                return obj;
            }
            // 空きがないなら新しく用意する
            T instance = m_onAlloc();
            m_useList.Add( instance );

            return instance;
        }

        /// <summary>
        /// 破棄
        /// </summary>
        public void Dispose()
        {
            m_onAlloc = default;
            m_useList.Clear();
            m_freeList.Clear();
        }
    }
}
