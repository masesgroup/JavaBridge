/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region DefaultListModel
    public partial class DefaultListModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#isEmpty()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#removeElement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool RemoveElement(object arg0)
        {
            return IExecute<bool>("removeElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#elementAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="object"/></returns>
        public object ElementAt(int arg0)
        {
            return IExecute("elementAt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#firstElement()"/>
        /// </summary>
        
        /// <returns><see langword="object"/></returns>
        public object FirstElement()
        {
            return IExecute("firstElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="object"/></returns>
        public object Get(int arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#lastElement()"/>
        /// </summary>
        
        /// <returns><see langword="object"/></returns>
        public object LastElement()
        {
            return IExecute("lastElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="object"/></returns>
        public object Remove(int arg0)
        {
            return IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#set(int,E)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object Set(int arg0, object arg1)
        {
            return IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#capacity()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Capacity()
        {
            return IExecute<int>("capacity");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#indexOf(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int IndexOf(object arg0, int arg1)
        {
            return IExecute<int>("indexOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#indexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int IndexOf(object arg0)
        {
            return IExecute<int>("indexOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#lastIndexOf(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int LastIndexOf(object arg0, int arg1)
        {
            return IExecute<int>("lastIndexOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#lastIndexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int LastIndexOf(object arg0)
        {
            return IExecute<int>("lastIndexOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#size()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#toArray()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteArray<object>("toArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#add(int,E)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        public void Add(int arg0, object arg1)
        {
            IExecute("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#addElement(E)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        public void AddElement(object arg0)
        {
            IExecute("addElement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#copyInto(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void CopyInto(object[] arg0)
        {
            IExecute("copyInto", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#ensureCapacity(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void EnsureCapacity(int arg0)
        {
            IExecute("ensureCapacity", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#insertElementAt(E,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        public void InsertElementAt(object arg0, int arg1)
        {
            IExecute("insertElementAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#removeAllElements()"/>
        /// </summary>
        public void RemoveAllElements()
        {
            IExecute("removeAllElements");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#removeElementAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void RemoveElementAt(int arg0)
        {
            IExecute("removeElementAt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#removeRange(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        public void RemoveRange(int arg0, int arg1)
        {
            IExecute("removeRange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#setElementAt(E,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        public void SetElementAt(object arg0, int arg1)
        {
            IExecute("setElementAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#setSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public void SetSize(int arg0)
        {
            IExecute("setSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListModel.html#trimToSize()"/>
        /// </summary>
        public void TrimToSize()
        {
            IExecute("trimToSize");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}