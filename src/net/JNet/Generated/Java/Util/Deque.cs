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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Deque
    public partial class Deque
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#getFirst()"/> 
        /// </summary>
        public object First
        {
            get { return IExecute("getFirst"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#getLast()"/> 
        /// </summary>
        public object Last
        {
            get { return IExecute("getLast"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(object arg0)
        {
            return IExecute<bool>("offer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#offerFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferFirst(object arg0)
        {
            return IExecute<bool>("offerFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#offerLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferLast(object arg0)
        {
            return IExecute<bool>("offerLast", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeFirstOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveFirstOccurrence(object arg0)
        {
            return IExecute<bool>("removeFirstOccurrence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeLastOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveLastOccurrence(object arg0)
        {
            return IExecute<bool>("removeLastOccurrence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#element()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Element()
        {
            return IExecute("element");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#peek()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Peek()
        {
            return IExecute("peek");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#peekFirst()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object PeekFirst()
        {
            return IExecute("peekFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#peekLast()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object PeekLast()
        {
            return IExecute("peekLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#poll()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Poll()
        {
            return IExecute("poll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#pollFirst()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object PollFirst()
        {
            return IExecute("pollFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#pollLast()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object PollLast()
        {
            return IExecute("pollLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#pop()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Pop()
        {
            return IExecute("pop");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#remove()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Remove()
        {
            return IExecute("remove");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeFirst()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object RemoveFirst()
        {
            return IExecute("removeFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeLast()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object RemoveLast()
        {
            return IExecute("removeLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#size()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#descendingIterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator DescendingIterator()
        {
            return IExecute<Java.Util.Iterator>("descendingIterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecute<Java.Util.Iterator>("iterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#addFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddFirst(object arg0)
        {
            IExecute("addFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#addLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddLast(object arg0)
        {
            IExecute("addLast", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#push(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Push(object arg0)
        {
            IExecute("push", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IDeque<E>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDeque<E> : Java.Util.IQueue<E>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#getFirst()"/> 
        /// </summary>
        E First { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#getLast()"/> 
        /// </summary>
        E Last { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Add(E arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        bool AddAll<Arg0ExtendsE>(Java.Util.Collection<Arg0ExtendsE> arg0) where Arg0ExtendsE: E;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Contains(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Offer(E arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#offerFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        bool OfferFirst(E arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#offerLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        bool OfferLast(E arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Remove(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeFirstOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool RemoveFirstOccurrence(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeLastOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool RemoveLastOccurrence(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#element()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E Element();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#peek()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E Peek();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#peekFirst()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E PeekFirst();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#peekLast()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E PeekLast();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#poll()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E Poll();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#pollFirst()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E PollFirst();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#pollLast()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E PollLast();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#pop()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E Pop();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#remove()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E Remove();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeFirst()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E RemoveFirst();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeLast()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E RemoveLast();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#size()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        int Size();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#descendingIterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        Java.Util.Iterator<E> DescendingIterator();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        Java.Util.Iterator<E> Iterator();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#addFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        void AddFirst(E arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#addLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        void AddLast(E arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#push(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        void Push(E arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Deque<E>
    public partial class Deque<E> : Java.Util.IDeque<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Deque{E}"/> to <see cref="Java.Util.Deque"/>
        /// </summary>
        public static implicit operator Java.Util.Deque(Java.Util.Deque<E> t) => t.Cast<Java.Util.Deque>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#getFirst()"/> 
        /// </summary>
        public E First
        {
            get { return IExecute<E>("getFirst"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#getLast()"/> 
        /// </summary>
        public E Last
        {
            get { return IExecute<E>("getLast"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(E arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll<Arg0ExtendsE>(Java.Util.Collection<Arg0ExtendsE> arg0) where Arg0ExtendsE: E
        {
            return IExecute<bool>("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(E arg0)
        {
            return IExecute<bool>("offer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#offerFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferFirst(E arg0)
        {
            return IExecute<bool>("offerFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#offerLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferLast(E arg0)
        {
            return IExecute<bool>("offerLast", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeFirstOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveFirstOccurrence(object arg0)
        {
            return IExecute<bool>("removeFirstOccurrence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeLastOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveLastOccurrence(object arg0)
        {
            return IExecute<bool>("removeLastOccurrence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#element()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Element()
        {
            return IExecute<E>("element");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#peek()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Peek()
        {
            return IExecute<E>("peek");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#peekFirst()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E PeekFirst()
        {
            return IExecute<E>("peekFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#peekLast()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E PeekLast()
        {
            return IExecute<E>("peekLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#poll()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Poll()
        {
            return IExecute<E>("poll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#pollFirst()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E PollFirst()
        {
            return IExecute<E>("pollFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#pollLast()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E PollLast()
        {
            return IExecute<E>("pollLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#pop()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Pop()
        {
            return IExecute<E>("pop");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#remove()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Remove()
        {
            return IExecute<E>("remove");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeFirst()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E RemoveFirst()
        {
            return IExecute<E>("removeFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#removeLast()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E RemoveLast()
        {
            return IExecute<E>("removeLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#size()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#descendingIterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> DescendingIterator()
        {
            return IExecute<Java.Util.Iterator<E>>("descendingIterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> Iterator()
        {
            return IExecute<Java.Util.Iterator<E>>("iterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#addFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void AddFirst(E arg0)
        {
            IExecute("addFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#addLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void AddLast(E arg0)
        {
            IExecute("addLast", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Deque.html#push(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void Push(E arg0)
        {
            IExecute("push", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}