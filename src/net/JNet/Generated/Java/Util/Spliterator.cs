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

namespace Java.Util
{
    #region Spliterator
    public partial class Spliterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#CONCURRENT"/>
        /// </summary>
        public static int CONCURRENT => Clazz.GetField<int>("CONCURRENT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#DISTINCT"/>
        /// </summary>
        public static int DISTINCT => Clazz.GetField<int>("DISTINCT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#IMMUTABLE"/>
        /// </summary>
        public static int IMMUTABLE => Clazz.GetField<int>("IMMUTABLE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#NONNULL"/>
        /// </summary>
        public static int NONNULL => Clazz.GetField<int>("NONNULL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#ORDERED"/>
        /// </summary>
        public static int ORDERED => Clazz.GetField<int>("ORDERED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#SIZED"/>
        /// </summary>
        public static int SIZED => Clazz.GetField<int>("SIZED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#SORTED"/>
        /// </summary>
        public static int SORTED => Clazz.GetField<int>("SORTED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#SUBSIZED"/>
        /// </summary>
        public static int SUBSIZED => Clazz.GetField<int>("SUBSIZED");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#getComparator()"/> 
        /// </summary>
        public Java.Util.Comparator Comparator
        {
            get { return IExecute<Java.Util.Comparator>("getComparator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#getExactSizeIfKnown()"/> 
        /// </summary>
        public long ExactSizeIfKnown
        {
            get { return IExecute<long>("getExactSizeIfKnown"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#tryAdvance(java.util.function.Consumer%3C? super T%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool TryAdvance(Java.Util.Function.Consumer arg0)
        {
            return IExecute<bool>("tryAdvance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#characteristics()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int Characteristics()
        {
            return IExecute<int>("characteristics");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#trySplit()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator TrySplit()
        {
            return IExecute<Java.Util.Spliterator>("trySplit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#estimateSize()"/>
        /// </summary>
        
        /// <returns><see cref="long"/></returns>
        public long EstimateSize()
        {
            return IExecute<long>("estimateSize");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#hasCharacteristics(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasCharacteristics(int arg0)
        {
            return IExecute<bool>("hasCharacteristics", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.html#forEachRemaining(java.util.function.Consumer%3C? super T%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        public void ForEachRemaining(Java.Util.Function.Consumer arg0)
        {
            IExecute("forEachRemaining", arg0);
        }
        
        #endregion

        #region Nested classes
        #region OfDouble
        public partial class OfDouble
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#tryAdvance(java.util.function.DoubleConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(Java.Util.Function.DoubleConsumer arg0)
            {
                return IExecute<bool>("tryAdvance", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#tryAdvance(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(object arg0)
            {
                return IExecute<bool>("tryAdvance", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#tryAdvance(java.util.function.Consumer%3C? super java.lang.Double%3E)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(Java.Util.Function.Consumer arg0)
            {
                return IExecute<bool>("tryAdvance", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#trySplit()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Spliterator.OfPrimitive"/></returns>
            public Java.Util.Spliterator.OfPrimitive TrySplit()
            {
                return IExecute<Java.Util.Spliterator.OfPrimitive>("trySplit");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecute("forEachRemaining", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#forEachRemaining(java.util.function.Consumer%3C? super java.lang.Double%3E)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            public void ForEachRemaining(Java.Util.Function.Consumer arg0)
            {
                IExecute("forEachRemaining", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfDouble.html#forEachRemaining(java.util.function.DoubleConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
            public void ForEachRemaining(Java.Util.Function.DoubleConsumer arg0)
            {
                IExecute("forEachRemaining", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OfInt
        public partial class OfInt
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#tryAdvance(java.util.function.IntConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(Java.Util.Function.IntConsumer arg0)
            {
                return IExecute<bool>("tryAdvance", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#tryAdvance(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(object arg0)
            {
                return IExecute<bool>("tryAdvance", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#tryAdvance(java.util.function.Consumer%3C? super java.lang.Integer%3E)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(Java.Util.Function.Consumer arg0)
            {
                return IExecute<bool>("tryAdvance", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#trySplit()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Spliterator.OfPrimitive"/></returns>
            public Java.Util.Spliterator.OfPrimitive TrySplit()
            {
                return IExecute<Java.Util.Spliterator.OfPrimitive>("trySplit");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecute("forEachRemaining", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#forEachRemaining(java.util.function.Consumer%3C? super java.lang.Integer%3E)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            public void ForEachRemaining(Java.Util.Function.Consumer arg0)
            {
                IExecute("forEachRemaining", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfInt.html#forEachRemaining(java.util.function.IntConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
            public void ForEachRemaining(Java.Util.Function.IntConsumer arg0)
            {
                IExecute("forEachRemaining", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OfLong
        public partial class OfLong
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#tryAdvance(java.util.function.LongConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(Java.Util.Function.LongConsumer arg0)
            {
                return IExecute<bool>("tryAdvance", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#tryAdvance(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(object arg0)
            {
                return IExecute<bool>("tryAdvance", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#tryAdvance(java.util.function.Consumer%3C? super java.lang.Long%3E)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(Java.Util.Function.Consumer arg0)
            {
                return IExecute<bool>("tryAdvance", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#trySplit()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Spliterator.OfPrimitive"/></returns>
            public Java.Util.Spliterator.OfPrimitive TrySplit()
            {
                return IExecute<Java.Util.Spliterator.OfPrimitive>("trySplit");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecute("forEachRemaining", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#forEachRemaining(java.util.function.Consumer%3C? super java.lang.Long%3E)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            public void ForEachRemaining(Java.Util.Function.Consumer arg0)
            {
                IExecute("forEachRemaining", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfLong.html#forEachRemaining(java.util.function.LongConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
            public void ForEachRemaining(Java.Util.Function.LongConsumer arg0)
            {
                IExecute("forEachRemaining", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OfPrimitive
        public partial class OfPrimitive
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Spliterator.OfPrimitive"/> to <see cref="Java.Util.Spliterator"/>
            /// </summary>
            public static implicit operator Java.Util.Spliterator(Java.Util.Spliterator.OfPrimitive t) => t.Cast<Java.Util.Spliterator>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfPrimitive.html#tryAdvance(T_CONS)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool TryAdvance(object arg0)
            {
                return IExecute<bool>("tryAdvance", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfPrimitive.html#trySplit()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Spliterator"/></returns>
            public Java.Util.Spliterator TrySplit()
            {
                return IExecute<Java.Util.Spliterator>("trySplit");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterator.OfPrimitive.html#forEachRemaining(T_CONS)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecute("forEachRemaining", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}